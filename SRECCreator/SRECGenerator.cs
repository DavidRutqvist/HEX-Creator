using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRECCreator
{
    class SRECGenerator : FileFormatGenerator
    {
        public string[] Generate(byte[][] rawBytes, int? maxWidth = null, byte? padding = null)
        {
            List<string> lines = new List<string>();

            lines.Add(GetHeader());

            int currentAddress = 0;

            foreach (var line in rawBytes)
            {
                int byteCount = line.Length;
                List<byte> message = new List<byte>();
                message.AddRange(line);

                if ((maxWidth != null) && (padding != null) && (byteCount < maxWidth))
                {
                    int missing = maxWidth.Value - byteCount;
                    for (int i = 0; i < missing; i++)
                    {
                        message.Add(padding.Value);
                    }
                }

                lines.Add(GetMessageFormatted(1, currentAddress, message.ToArray()));

                currentAddress += byteCount;
            }

            lines.Add(GetTail());

            return lines.ToArray();
        }

        private string GetHeader()
        {
            var message = CommonHelper.ToNullTerminated(DateTime.Now.ToString("yyMMdd hh:MM:ss"));
            if (message.Length > 80)
            {
                message = message.Substring(0, 80);//Max 80 characters in total
            }

            return GetMessageFormatted(0, 0, CommonHelper.GetBytes(message));
        }

        private string GetTail()
        {
            return GetMessageFormatted(9, 3, 0, new byte[0]);
        }

        private string GetMessageFormatted(int type, int address, byte[] bytes)
        {
            int count = bytes.Length + 2 + 1;//Bytes + address + checksum

            string data = String.Format("{0}{1}{2}", count.ToString("X2"), address.ToString("X4"), CommonHelper.BytesToHexRepresentation(bytes));

            return String.Format("S{0}{1}{2}", type, data, GetChecksum(data).ToString("X2"));
        }

        private string GetMessageFormatted(int type, int count, int address, byte[] bytes)
        {
            string data = String.Format("{0}{1}{2}", count.ToString("X2"), address.ToString("X4"), CommonHelper.BytesToHexRepresentation(bytes));

            return String.Format("S{0}{1}{2}", type, data, GetChecksum(data).ToString("X2"));
        }

        private UInt16 GetChecksum(string data)
        {
            if ((data.Length % 2) != 0)
            {
                throw new Exception("Misaligned data, probably off by one.");
            }

            UInt16 sum = 0;
            for (int i = 0; i < data.Length; i += 2)
            {
                sum += Convert.ToUInt16(data.Substring(i, 2), 16);
            }

            return (UInt16)((~sum) & 0xFF);
        }
    }
}
