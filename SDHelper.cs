using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SigmaDelta
{
	internal class SDInstance
	{
		SDGen sdGen;
		Sinc3Filter sinc3Filter;

		bool _bIsRunning;

		double _Vin;
		double _Vout;
		double _pVref;
		double _nVref;
		int _fullScaleVal = 1;
		double _fullScalePreVref = 1;

		public SDInstance(double pVref, double nVref, int ratio)
		{
            _pVref = pVref;
            _nVref = nVref;
			sdGen = new SDGen(pVref, nVref);
			sinc3Filter = new Sinc3Filter(ratio);
			var pos = GetBitPosition(ratio);
			if (pos > 0 && pos < 11)
			{
				_fullScaleVal = 1 << (pos * 3);
				_fullScalePreVref = (pVref - nVref) / _fullScaleVal;
			}
		}

		public bool SetVin(double vin)
		{
			if (vin > _nVref && vin <= _pVref)
			{
                _Vin = vin;
                return true;
			}
            return false;
		}

		public double GetRawVout()
		{
			return _Vout;
		}

		public double GetVout()
		{
			return _Vout * _fullScalePreVref + _nVref;
		}

		public void Catch()
        {
			sdGen.Catch();
		}

		private int GetBitPosition(int ratio)
		{
			for (int i = 30; i > 0; i--)
			{
				var mask = 1 << i;
				if ((ratio & mask) == mask)
					return i;
			}
            return -1;
		}

		public void Start()
		{
			if (!_bIsRunning)
			{
				_bIsRunning = true;
                Task.Factory.StartNew(() =>
                {
					int sampleCount = 0;
					uint i = 1;
                    while (_bIsRunning)
                    {
                        while (i % 1000000 != 0)
                        {
							bool ret = sdGen.Generate(_Vin, sampleCount++);
							_Vout = sinc3Filter.Generate(ret);
							i++;
							if (!_bIsRunning) return;
						}
						i++;
						Thread.Sleep(100);
                    }
                });
			}
		}

		public void Stop()
        {
			_bIsRunning = false;
			Thread.Sleep(100);
            sdGen.Clear();
            sinc3Filter.Clear();
		}
	}

	internal class SDHelper
	{
		
	}
}
