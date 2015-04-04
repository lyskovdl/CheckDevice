using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDeviceArgo.BL
{
    public class PortData
    {
        #region Variables
        private string _portName;
        private int _portBaudRate;
        private int _portTimeout=5000;
        private string _portProtocol="BIN";
        #endregion

        #region Properties
        public string PortName
        {
            get { return _portName; }
            set { _portName = value; }
        }

        public int PortBaudRate
        {
            get { return _portBaudRate; }
            set { _portBaudRate = value; }
        }

        public int PortTimeout
        {
            get { return _portTimeout; }
            set { _portTimeout = value; }
        }
        public  string Protocol
        {
            get { return _portProtocol; }
            set { _portProtocol = value; }
        }

        #endregion

        public PortData(string portName, int portBaudRate)
        {
            _portName = portName; _portBaudRate = portBaudRate;
        } 
    }
}
