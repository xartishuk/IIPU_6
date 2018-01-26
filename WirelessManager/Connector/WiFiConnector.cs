using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeWifi;
using SimpleWifi;

namespace WirelessManager.Connector
{
    sealed class WiFiConnector
    {
        private static WiFiConnector _instance;
        public static WiFiConnector GetInstance() { return _instance ?? (_instance = new WiFiConnector()); }
        /*
        public void Connect(string name, string password)
        {
            var client = new WlanClient();
            foreach (var wlanIface in client.Interfaces)
            {
                var wlanBssEntries = wlanIface.GetAvailableNetworkList(0);
                foreach (var network in wlanBssEntries)
                {
                    var profileName = Encoding.ASCII.GetString(network.dot11Ssid.SSID);
                    if (profileName == name)
                    {
                        var strTemplate = "";
                        var authentication = "";
                        switch ((int)network.dot11DefaultAuthAlgorithm)
                        {
                            case 1: // Open
                                break;
                            case 3: // WEP
                                break;
                            case 4: // WPA_PSK
                                strTemplate = Properties.Resources.WPAPSK;
                                authentication = "WPAPSK";
                                var encryption = network.dot11DefaultCipherAlgorithm.ToString().Trim((char)0);
                                var profileXml = string.Format(strTemplate, profileName, authentication, encryption, password);
                                wlanIface.SetProfile(Wlan.WlanProfileFlags.AllUser, profileXml, true);
                                wlanIface.Connect(Wlan.WlanConnectionMode.Profile, Wlan.Dot11BssType.Any, profileName);
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
        }
        */


        public bool Connect(string name, string password)
        {
            var wifi = new Wifi();
            var selectedAP = wifi.GetAccessPoints().First(p => p.Name == name.Trim((char)0));
            if (selectedAP != null)
            {
                var authRequest = new AuthRequest(selectedAP);
                if (authRequest.IsPasswordRequired)
                {
                    authRequest.Password = password;
                }
                return selectedAP.Connect(authRequest);
            }
            return false;
        }
    }
}
