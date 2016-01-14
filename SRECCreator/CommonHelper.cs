using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRECCreator
{
    class CommonHelper
    {
        public static byte[] GetBytes(string text)
        {
            return ASCIIEncoding.ASCII.GetBytes(text);
        }

        public static byte[][] GetBytes(string[] lines) {
            byte[][] byteLines = new byte[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                byteLines[i] = GetBytes(lines[i]);
            }
            return byteLines;
        }

        public static string GetString(byte[] bytes)
        {
            return ASCIIEncoding.ASCII.GetString(bytes);
        }

        public static string GetString(byte b)
        {
            byte[] buf = new byte[1];
            buf[0] = b;
            return GetString(buf);
        }

        public static string BytesToHexRepresentation(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var b in bytes)
            {
                sb.Append(((int)b).ToString("X2"));
            }

            return sb.ToString();
        }

        public static string ToNullTerminated(string text)
        {
            return text + "\0";
        }
    }
}
