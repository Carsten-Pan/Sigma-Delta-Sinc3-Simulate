using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// build for: AMC1306

namespace SigmaDelta
{
	internal class SDGen
	{
		double _pVref = 0;
        double _nVref = 0;
		double _Vin = 0;
        double _V1 = 0;
		double _V2 = 0;
		double _V3 = 0;
		double _V4 = 0;
		double _V5 = 0;
		int _sampleCount = 0;

		public double Time { get { return _sampleCount / 1000000.0; } }

		public SDGen(double pVref = 5, double nVref = 0)
		{
			_pVref = pVref;
			_nVref = nVref;
		}

		public void Clear()
        {
			_V1 = 0;
			_V2 = 0;
            _V3 = 0;
			_V4 = 0;
			_V5 = 0;
			_sampleCount = 0;
		}

        public bool Generate(double Vin, int sampleCount)
		{
			_sampleCount = sampleCount;
			if (Vin > _nVref && Vin <= _pVref)
				_Vin = Vin;
			_V1 = Vin - _V5;
			_V2 += _V1;
			_V3 += _V2;
			_V4 = _Vin - _V3 - _V2;
			bool returnValue = _V4 <= 0;
			if (returnValue)
			{
				_V5 = _pVref;
			}
			else
			{
				_V5 = _nVref;
			}
			return returnValue;
        }
	}
}
