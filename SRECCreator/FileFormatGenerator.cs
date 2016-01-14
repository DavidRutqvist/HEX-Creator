using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRECCreator
{
    interface FileFormatGenerator
    {
        string[] Generate(byte[][] rawBytes, int? maxWidth = null, byte? padding = null);
    }
}
