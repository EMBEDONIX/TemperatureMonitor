using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using TempMonitor.Libraries.EventArgs;

namespace TempMonitor.Libraries
{
    public class DataReader
    {
        //public members        
        public event EventHandler<PacketReceivedEventArgs> PacketReceived;
        public event EventHandler<SyncStateChangedEventArgs> SyncStateChanged;
        private Task _task;
        private bool _doWork;

        //private members
        private SerialPort _port;

        public DataReader(SerialPort port)
        {
            _port = port;
        }

        public void Start()
        {
            if (_port == null || !_port.IsOpen)
                return;

            _doWork = true;
            _task = Task.Run(() => { Read(); });
            //_task.Wait();
        }

        public void Stop()
        {

            if (_task.Status == TaskStatus.Running)
            {
                //TODO stop task
                
            }
            _doWork = false;
            //_task.Wait();
        }


        private void Read()
        {

            var crashCount = 0;
            while (_port.IsOpen && _doWork)
            {
                try
                {                                     
                    var buffer = _port.ReadExisting();
                    if (string.IsNullOrWhiteSpace(buffer))
                    {
                        continue;
                    }

                    var bufferList = buffer.Select(c => (byte)c).ToList();
                    var sIndex = bufferList.IndexOf(Protocol.StartByte);

                    if (bufferList[sIndex + 1] == 0 && bufferList[sIndex + 3] == 66)
                    {
                        if (bufferList[sIndex + Protocol.PacketSize - 2] == 0
                            && bufferList[sIndex + Protocol.PacketSize - 1] == Protocol.StopByte)
                        {    
                            var shit = bufferList.Skip(sIndex).Take(Protocol.PacketSize).ToArray();
                            OnPacketReceived(shit);
                        }
                    }

                    if (crashCount > 1)
                    {
                        crashCount--;
                    }
                }
                catch (Exception e)
                {
                    crashCount++;
                    Debug.WriteLine("Error in reading buffer: " + e.Message);
                    SyncStateChanged(this, new SyncStateChangedEventArgs(_port.PortName, _port, SyncState.OutOfSync));
                    if (crashCount > 1000)
                    {
                        //TODO warn user with someting like messagebox to reset the connection
                        break;
                    }
                }

            }
        }

        private void OnPacketReceived(IList buffer)
        {
            if (PacketReceived != null)
            {
                PacketReceived(this, new PacketReceivedEventArgs((byte[])buffer));
            }
        }

        private void OnSyncStateChanged(string name, SerialPort port, SyncState state)
        {
            if (SyncStateChanged != null)
            {
                SyncStateChanged(this, new SyncStateChangedEventArgs(name, port, state));
            }
        }
    }
}