using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// build for: ADS1202

namespace SigmaDelta
{
	internal class Sinc3Filter
	{
        public double Time;

		uint _Delta = 0;
		uint _CN1, _CN2, _CN3, _CN4, _CN5;
		uint _DN0, _DN1, _DN3, _DN5;
		int _M; // ratio
		int _temp;

        public Sinc3Filter(int m)
        {
            _M = m;
        }

		public void Clear()
		{
			_Delta = 0;
			_CN1 = 0;
			_CN2 = 0;
			_CN3 = 0;
			_CN4 = 0;
			_CN5 = 0;
			_DN0 = 0;
			_DN1 = 0;
			_DN3 = 0;
			_DN5 = 0;
			_temp = 0;
		}

        public double Generate(bool vin)
		{
			_CN2 += _CN1;
			_CN1 += _Delta;
			_Delta += (uint)(vin ? 1 : 0);

			if (_temp >= _M)
			{
				_temp = 0;
				_CN3 = _DN0 - _DN1;
				_CN4 = _CN3 - _DN3;
				_CN5 = _CN4 - _DN5;
				_DN5 = _CN4;
				_DN3 = _CN3;
				_DN1 = _DN0;
				_DN0 = _CN2;
			}

			_temp++;
			return _CN5;
		}
	}
}
