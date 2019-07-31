using System;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace _5gpro.Funcoes
{
    public class NetworkAdapter
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

        public static string GetLocalIpAddress()
        {
            foreach (var netI in NetworkInterface.GetAllNetworkInterfaces())
            {
                if(!(
                    netI.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    netI.NetworkInterfaceType == NetworkInterfaceType.Ethernet) && netI.OperationalStatus != OperationalStatus.Up
                    )continue;
                foreach (var uniIpAddrInfo in netI.GetIPProperties().UnicastAddresses.Where(x => netI.GetIPProperties().GatewayAddresses.Count > 0))
                {

                    if (uniIpAddrInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                        return uniIpAddrInfo.Address.ToString();
                }
            }
            return null;
        }

        public static string GetMacAddress()
        {
            foreach (var netI in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (!(
                    netI.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    netI.NetworkInterfaceType == NetworkInterfaceType.Ethernet) && netI.OperationalStatus != OperationalStatus.Up
                    ) continue;
                foreach (var uniIpAddrInfo in netI.GetIPProperties().UnicastAddresses.Where(x => netI.GetIPProperties().GatewayAddresses.Count > 0))
                {

                    if (uniIpAddrInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                        return netI.GetPhysicalAddress().ToString();
                }
            }
            return null;
        }

        public NetworkAdapter()
        {
            this._IP = GetLocalIpAddress();
            this._MAC = GetMacAddress();
            this.NomePC = Environment.MachineName;
        }
    }
}
