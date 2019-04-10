using System;
using System.Management;

namespace _5gpro.Funcoes
{
    class NetworkAdapter
    {
        private string _MAC = "";
        private string _IP = "";
        private string NomePC;

        public string Mac
        {
            get { return _MAC; }
        }

        public string IP
        {
            get { return _IP; }
        }

        public string Nome
        {
            get { return NomePC; }
        }

        public NetworkAdapter()
        {
            ManagementObjectSearcher ObjMOS = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
            ManagementObjectCollection ObjMOC = ObjMOS.Get();


            foreach (ManagementObject mo in ObjMOC)
            {
                string[] addresses = (string[])mo["IPAddress"];
                this._IP = addresses[0];
                this._MAC = addresses[1];
            }
            this.NomePC = Environment.MachineName;
        }
    }
}
