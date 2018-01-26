using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WirelessManager.Network;
using WirelessManager.Scanner;

namespace WirelessManager.Dispatcher
{
    sealed class WiFiDispatcher
    {
        private static WiFiDispatcher _instance;
        private WiFiDispatcher() { Update(); }
        private WiFiScanner scanner = WiFiScanner.GetInstance();
        public static WiFiDispatcher GetInstance()
        {
            return _instance ?? (_instance = new WiFiDispatcher());
        }
        public List<WiFiNetwork> Networks { get; private set; }
        public List<WiFiNetwork> Update()
        {
            return Networks = scanner.UpdateNetworks();
        }
    }
}
