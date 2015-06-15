using System.IO.Ports;

namespace TempMonitor.Libraries.EventArgs
{
    public class SyncStateChangedEventArgs : System.EventArgs
    {
        public SyncStateChangedEventArgs(string portName, SerialPort serialPort, SyncState syncState)
        {
            PortName = portName;
            PortInstance = serialPort;
            State = syncState;
        }

        /// <summary>
        ///     Get the state
        /// </summary>
        public SyncState State { get; private set; }

        /// <summary>
        ///     Get name of the port which raised this event
        /// </summary>
        public string PortName { get; private set; }

        /// <summary>
        ///     Get reference to the serial port which raised this event
        /// </summary>
        public SerialPort PortInstance { get; private set; }
    }
}