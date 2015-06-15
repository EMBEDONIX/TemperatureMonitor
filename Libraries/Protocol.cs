using System;

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
            var bytes = new byte[str.Length*sizeof (char)];
            Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
    }
}