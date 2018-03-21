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
    public partial class mainform : Form
    {
        private Thread alt_thread;

        public mainform()
        {
            InitializeComponent();

            //define other form thread
            alt_thread = new Thread(() =>
            {
                testform newform = new testform();
                Application.Run(newform);
            });

            //loop
            bool end = true;
            var thread = new Thread(() =>
            {
                while(end)
                {
                    lftlbl.ForeColor = System.Drawing.Color.Red;
                    rgtlbl.ForeColor = System.Drawing.Color.Blue;
                    Thread.Sleep(1000);
                    lftlbl.ForeColor = System.Drawing.Color.Blue;
                    rgtlbl.ForeColor = System.Drawing.Color.Red;
                    Thread.Sleep(1000);
                }

            });
            thread.Start();
        }

        private void actbtn_Click(object sender, EventArgs e)
        {
            lock(alt_thread)
            {
                //if the second form is not open create it
                if (!alt_thread.IsAlive)
                {
                    //define other form thread
                    alt_thread = new Thread(() =>
                    {
                        testform newform = new testform();
                        Application.Run(newform);
                    });

                    alt_thread.Start();
                }
            }
        }
    }
}
