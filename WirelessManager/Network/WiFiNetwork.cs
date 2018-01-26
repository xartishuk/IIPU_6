using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WirelessManager.Connector;

namespace WirelessManager.Network
{
    class WiFiNetwork
    {
        public string Name { get; set; }
        public string MAC { get; set; }
        public string ConnectionQuality { get; set; }
        public string AuthenticationType { get; set; }
        public bool Connected { get; set; }

        public bool Connect(string password)
        {
            return WiFiConnector.GetInstance().Connect(this.Name, password);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) { return true; }
            if (this.GetType() != obj.GetType()) { return false; }

            var wifi = (WiFiNetwork)obj;

            if (this.Name != wifi.Name) { return false; }
            //if (this.MAC != wifi.MAC) { return false; }
            if (this.ConnectionQuality != wifi.ConnectionQuality) { return false; }
            if (this.AuthenticationType != wifi.AuthenticationType) { return false; }
            return true;
        }
        public override int GetHashCode()
        {
            int hash = Name.GetHashCode();
            hash = 31 * hash + MAC.GetHashCode();
            hash = 31 * hash + ConnectionQuality.GetHashCode();
            hash = 31 * hash + AuthenticationType.GetHashCode();
            return hash;
        }
    }
}
