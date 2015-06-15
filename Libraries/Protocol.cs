using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TempMonitor.Libraries
{
    public static class Protocol
    {
        public const byte StartByte = 126;
        public const byte StopByte = 127;
        public const int PacketSize = 24;
        public const int TxDelayBase = 100;

        public static int GetTxDelay(int multiplier)
        {
            return multiplier*TxDelayBase;
        }

        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

    }
}
