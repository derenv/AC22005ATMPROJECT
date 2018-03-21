using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Multithread_forms
{
    public partial class testform : Form
    {
        public testform()
        {
            InitializeComponent();
        }

        private void testform_Load(object sender, EventArgs e)
        {
            bool end = false;
            var thread = new Thread(() =>
            {
                while (!end)
                {
                    lftlbl.ForeColor = System.Drawing.Color.Green;
                    rgtlbl.ForeColor = System.Drawing.Color.Yellow;
                    Thread.Sleep(1000);
                    lftlbl.ForeColor = System.Drawing.Color.Yellow;
                    rgtlbl.ForeColor = System.Drawing.Color.Green;
                    Thread.Sleep(1000);
                }

            });
            thread.Start();
        }
    }
}
