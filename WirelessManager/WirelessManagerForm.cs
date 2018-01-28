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
            _dispatcher.Update();
            var networks = _dispatcher.Networks;

            var selectedRows = NetworksGridView.SelectedRows;
            DataGridViewRow selectedRow = null;
            string selectedData = "";
            if (selectedRows.Count != 0) {
                selectedRow = selectedRows[0];
                selectedData = selectedRow.Cells[0].Value.ToString();
            }

            ListSortDirection sortOrder = ListSortDirection.Ascending;
            DataGridViewColumn sortedCollumn = null;
            var sorted = false;
            if (NetworksGridView.SortOrder != SortOrder.None)
            {
                sorted = true;
                sortOrder = NetworksGridView.SortOrder == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending;
                sortedCollumn = NetworksGridView.SortedColumn;
            }

            NetworksGridView.Rows.Clear();
            foreach (var network in networks)
            {
                NetworksGridView.Rows.Add(network.Name, network.ConnectionQuality, network.AuthenticationType, network.MAC);
            }

            if (sorted) NetworksGridView.Sort(sortedCollumn, sortOrder);
            foreach (DataGridViewRow row in NetworksGridView.Rows) { if (row.Cells[0].Value.ToString().Equals(selectedData)) { row.Selected = true; break; } }

            this.UpdateButtons();
        }

        private void WirelessManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _updater.IsInterrupted = true;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            var networks = _dispatcher.Networks;
            var selectedName = NetworksGridView.SelectedRows[0].Cells[0].Value.ToString();
            var currentNetwork = networks.First(x => x.Name.Equals(selectedName));
            if (currentNetwork.Connected == false)
            {
                /*foreach (var n in networks)
                {
                    n.Connected = false;
                }*/
                try
                {
                    if (currentNetwork.Connect(passwordTextBox.Text))
                    {
                        MessageBox.Show(this, "You've connected to the network", "OK - Wireless Manager");
                        currentNetwork.Connected = true;
                        foreach (var n in networks) { if (n != currentNetwork) { n.Connected = false; } }
                    } else
                    {
                        MessageBox.Show(this, "Cannot connect to the network", "Error - Wireless Manager");
                    }
                    this.UpdateButtons();
                }
                catch { MessageBox.Show(this, "Cannot connect to the network", "Error - Wireless Manager"); }
            }
        }

        private void UpdateButtons()
        {
            var networks = _dispatcher.Networks;
            var selectedName = NetworksGridView.SelectedRows[0].Cells[0].Value.ToString();
            var currentNetwork = networks.First(x => x.Name.Equals(selectedName));

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
