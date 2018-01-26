using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WirelessManager.Updater
{
    class DataUpdater
    {
        private Thread _updaterThread;
        private WirelessManagerForm _form;
        public bool IsInterrupted { get; set; }

        public DataUpdater(WirelessManagerForm form)
        {
            this._form = form;
            this._updaterThread = new Thread(this.updateData);
            this.IsInterrupted = false;
            _updaterThread.Start();
        }

        private void updateData()
        {
            const int ONE_SECOND = 1000;
            while (!IsInterrupted)
            {
                Thread.Sleep(ONE_SECOND);
                try { _form.Invoke((MethodInvoker)delegate { _form.UpdateData(); }); }
                catch { break; }
            }
        }
    }
}
