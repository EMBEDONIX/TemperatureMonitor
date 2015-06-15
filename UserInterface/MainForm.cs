using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using SpPerfChart;
using TempMonitor.Controls;
using TempMonitor.Libraries;
using TempMonitor.Libraries.EventArgs;
using TempMonitor.UserInterface.Properties;

namespace TempMonitor.UserInterface
{
    public partial class MainForm : MetroForm
    {
        private SerialPort _port;
        private DataReader _reader;
        //private bool _isBusy = false;
        private int hahahagitlol;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            RefreshPresentComPorts();
        }

        private void RefreshPresentComPorts()
        {

            cbPorts.Items.Clear();
            foreach (var p in SerialPort.GetPortNames())
            {
                cbPorts.Items.Add(p);
            }

            if (cbPorts.Items.Count > 0)
            {
                cbPorts.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Can not find any COM ports on this PC!");
            }
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {

            if (_port != null)
            {
                try
                { 
                    if (_reader != null)
                    {
                        _reader.Stop();
                    }
                }
                catch
                {

                }
                finally
                {
                    if (_port.IsOpen)
                    {
                        _port.Close();
                    }
                    _port = null;
                    btnConnect.Text = "CONNECT";
                    labelRxState.Text = "NOT CONNECTED";
                    pictureBoxStatus.Image = Resources.disconnected;
                    cbPorts.Enabled = true;
                }
                
                return;
                
            }
            
            if (cbPorts.SelectedItem == null)
            {
                MessageBox.Show(Resources.MainForm_btnConnect_Click_Please_select_a_COM_Port_first_);
            }
            else
            {
                var p = cbPorts.SelectedItem.ToString();

                //Now make a new connection
                _port = new SerialPort(p, 115200, Parity.None)
                {
                    ReadBufferSize = 64,
                    Encoding = Encoding.Default,
                    DiscardNull =  false
                };
                _port.ReadTimeout = 1000;
                _port.WriteTimeout = 1000;
                _port.Handshake = Handshake.None;
                try
                {
                    _port.Open();
                }
                catch
                {
                    MessageBox.Show("Can not open " + p +
                                    ". Make sure the port is available and it is not being used by any other application");
                    _port = null;
                    return;
                }

                if (_port.IsOpen)
                {
                    _reader = new DataReader(_port);
                    _reader.PacketReceived += DateReceived;
                    _reader.Start();
                    btnConnect.Text = "DISCONNECT";
                    labelRxState.Text = "CONNECTED";
                    pictureBoxStatus.Image = Resources.connected;
                    cbPorts.Enabled = false;
                }
            }
        }

        private Int64 counter = 0;
        private void DateReceived(object sender, PacketReceivedEventArgs e)
        {
            GraphPoint[] samples = ParseSamples(e.MessageBuffer);

            try
            {
                if (samples != null)
                {
                    sensorPanel.BeginInvoke((Action) delegate
                    {
                        sensorPanel.AddSample(samples);
                    });
                }

            }
            catch (InvalidOperationException ioe)
            {
                Debug.WriteLine("Error in DateReceived() " + ioe.Message);
            }
            catch (ThreadInterruptedException tie)
            {
                Debug.WriteLine("Error in DateReceived() " + tie.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error in DateReceived() " + ex.Message);
            }
        }

        private GraphPoint[] ParseSamples(byte[] buffer)
        {
            var now = DateTime.Now;
            UInt32[] values = new UInt32[4];
            try
            {
            values[0] = BitConverter.ToUInt32(buffer, 4);
            values[1] = BitConverter.ToUInt32(buffer, 8);
            values[2] = BitConverter.ToUInt32(buffer, 12);
            values[3] = BitConverter.ToUInt32(buffer, 16);
            }
            catch (Exception)
            {
                return null;
            }

            //check if any of parsed values are bigger than 4095
            //this means we are out of sync!!

            bool isOk = values.All(x => x < 4096);
            if (!isOk || buffer[2] > 14)
                {

                labelRxState.BeginInvoke((Action)delegate
                {
                    labelRxState.Text = "SYNCING";
                });
                
                return null;
            }

            labelRxState.BeginInvoke((Action) delegate
            {
                labelRxState.Text = "RECEIVE DELAY: " + Protocol.GetTxDelay(buffer[2]) + "ms";    
            });
            
            

            GraphPoint[] samples =
            {
                new GraphPoint(now, "1", values[0]),
                new GraphPoint(now, "2", values[1]),
                new GraphPoint(now, "3", values[2]),
                new GraphPoint(now, "4", values[3])
            };

            return samples;
        }

        private void cbPorts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RefreshPresentComPorts();
        }

        private void cbPorts_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshPresentComPorts();
        }

    }
}