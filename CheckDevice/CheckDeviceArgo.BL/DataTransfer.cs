using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDeviceArgo.BL
{
    public interface IDataTransfer
    {
        bool OpenPort(string portNum);
        bool OpenPort(string portNum, int baudRate);
        bool closePort(int portNum);
    }

    public class DataTransfer : IDataTransfer
    {
        private int _baudRate =9600;

        public bool OpenPort(string portNum)
        {
            return OpenPort(portNum, _baudRate);
        }

        public bool OpenPort(string portNum, int baudRate)
        {
            PortData port1 = new PortData(portNum, baudRate);
            SerialPort comPort1 = new SerialPort(port1.PortName, port1.PortBaudRate);
            return true;
        }

        public bool closePort(int portNum)
        {
            return true;
        }

    }
}
