using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Services
{
    public class WeighbridgeService
    {
        public List<string> GetPorts()
        {

            string[] ports= SerialPort.GetPortNames();
            List<string> portList = new List<string>(ports);
            return portList;
        }
    }
}
