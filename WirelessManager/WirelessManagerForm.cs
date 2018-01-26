using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WirelessManager.Dispatcher;
using WirelessManager.Updater;

namespace WirelessManager
{
    public partial class WirelessManagerForm : Form
    {
        private WiFiDispatcher _dispatcher = WiFiDispatcher.GetInstance();
        private DataUpdater _updater;
        public WirelessManagerForm()
        {
            InitializeComponent();
            NetworksGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            NetworksGridView.MultiSelect = false;
            this._updater = new DataUpdater(this);
        }


        public void UpdateData()
        {
            var networks = _dispatcher.Networks;
            var selectedRows = NetworksGridView.SelectedRows;
            int? selectedIndex = null;
            if (selectedRows.Count != 0) { selectedIndex = selectedRows[0].Index; }
            NetworksGridView.Rows.Clear();
            foreach (var network in networks)
            {
                NetworksGridView.Rows.Add(network.Name, network.ConnectionQuality, network.AuthenticationType, network.MAC);
            }
            NetworksGridView.Rows[selectedIndex??0].Selected = true;
            this.UpdateButtons();
        }

        private void WirelessManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _updater.IsInterrupted = true;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            var networks = _dispatcher.Networks;
            var selectedIndex = NetworksGridView.SelectedRows[0].Index;
            var currentNetwork = networks[selectedIndex];
            if (currentNetwork.Connected == false)
            {
                foreach (var n in networks)
                {
                    n.Connected = false;
                }
                try
                {
                    if (currentNetwork.Connect(passwordTextBox.Text))
                    MessageBox.Show(this, "You've connected to the network", "OK - Wireless Manager");
                    currentNetwork.Connected = true;
                    foreach (var n in networks) { if (n != currentNetwork) { n.Connected = false; } }
                    this.UpdateButtons();
                }
                catch { MessageBox.Show(this, "Cannot connect to the network", "Error - Wireless Manager"); }
            }
        }

        private void UpdateButtons()
        {
            var networks = _dispatcher.Networks;
            var selectedIndex = NetworksGridView.SelectedRows[0].Index;
            var currentNetwork = networks[selectedIndex];

            if (currentNetwork.Connected)
            {
                connectButton.Enabled = false;
                connectedLabel.Text = "Connected";
            }
            else
            {
                connectButton.Enabled = true;
                connectedLabel.Text = "Disconnected";
            }
        }

        private void NetworksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.UpdateButtons();
        }
    }
}
