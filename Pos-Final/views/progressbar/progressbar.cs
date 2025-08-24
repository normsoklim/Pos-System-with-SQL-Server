using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_Final.views.progressbar
{
    public partial class progressbar : Form
    {
        public progressbar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            myfirstprogressbar.Value += 1;
            if (myfirstprogressbar.Value >= myfirstprogressbar.Maximum)
            {
                timer1.Stop();
                this.Hide();
                LogInForm loginForm = new LogInForm();
               loginForm.ShowDialog();
              
            }
        }

        private void progressbar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void myfirstprogressbar_Click(object sender, EventArgs e)
        {

        }
    }
}
