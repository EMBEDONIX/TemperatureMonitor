namespace TempMonitor.Libraries.EventArgs
{
    public class PacketReceivedEventArgs : System.EventArgs
    {
        private byte[] _buffer;
        public byte[] MessageBuffer 
        { 
            get { return _buffer; }
        }

        public PacketReceivedEventArgs(byte[] buffer)
        {
            _buffer = buffer;
        }                                               
    }
}
