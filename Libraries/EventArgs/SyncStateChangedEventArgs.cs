using System.IO.Ports;

namespace TempMonitor.Libraries.EventArgs
{
    public class SyncStateChangedEventArgs : System.EventArgs
    {
        private SyncState _syncState;
        private string _portName;
        private SerialPort _serialPort;

        /// <summary>
        /// Get the state
        /// </summary>
        public SyncState State { get { return _syncState;} }

        /// <summary>
        /// Get name of the port which raised this event
        /// </summary>
        public string PortName { get { return _portName; }}

        /// <summary>
        /// Get reference to the serial port which raised this event
        /// </summary>
        public SerialPort PortInstance { get { return _serialPort; } }

        public SyncStateChangedEventArgs(string portName, SerialPort serialPort, SyncState syncState)
        {
            _portName = portName;
            _serialPort = serialPort;
            _syncState = syncState;
        }
    }
}
