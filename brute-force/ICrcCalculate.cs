using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brute_force
{
    interface ICrcCalculate
    {
        int CrcDataLength { get; }
        CRC Calculate(byte[] buffer, int offset, int length);
    }
}
