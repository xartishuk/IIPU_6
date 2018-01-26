using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WirelessManager.Network;
using NativeWifi;

namespace WirelessManager.Scanner
{
    sealed class WiFiScanner
    {
        private static WiFiScanner _instance;
        private WiFiScanner() { }
        public static WiFiScanner GetInstance()
        {
            return _instance ?? (_instance = new WiFiScanner());
        }

        public List<WiFiNetwork> Networks { get; private set; }
        public List<WiFiNetwork> UpdateNetworks()
        {
            var wifiList = new List<WiFiNetwork>();
            var client = new WlanClient();
            foreach (var wlanIface in client.Interfaces)
            {
                var wlanBssEntries = wlanIface.GetAvailableNetworkList(0);
                var macIndex = 0;
                foreach (var network in wlanBssEntries)
                {
                    var wifi = new WiFiNetwork();
                    wifi.Name = Encoding.ASCII.GetString(network.dot11Ssid.SSID);
                    wifi.ConnectionQuality = network.wlanSignalQuality.ToString() + "%";
                    wifi.AuthenticationType = network.dot11DefaultAuthAlgorithm.ToString();
                    if (wifiList.Contains(wifi)) { continue; }
                    wifi.MAC = wlanIface.GetNetworkBssList()[macIndex].dot11Bssid.Select(b => b.ToString("x2")).Aggregate((cur, next) => cur + ':' + next);//.Trim((char)0);
                    wifi.Connected = false;
                    wifiList.Add(wifi);
                    macIndex++;
                }
            }
            return Networks = wifiList;
        }
    }
}
