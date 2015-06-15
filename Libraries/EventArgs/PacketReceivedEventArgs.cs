namespace TempMonitor.Libraries.EventArgs
{
    public class PacketReceivedEventArgs : System.EventArgs
    {
        public PacketReceivedEventArgs(byte[] buffer)
        {
            MessageBuffer = buffer;
        }

        public byte[] MessageBuffer { get; private set; }
    }
}