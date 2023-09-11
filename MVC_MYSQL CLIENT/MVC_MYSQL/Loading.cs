using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_MYSQL
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        int second = 0;
        bool move;
        int x, y;

        private void Loading_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Loading_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            x = e.X;
            y = e.Y; ;
        }

        private void Loading_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            second++;
            progressBar.Left += 2;
            if (progressBar.Left + progressBar.Width > center_panel.Width + 60)
                progressBar.Left = 0;
            if (second == 330)
            {
                SignIn log = new SignIn();
                timerProgress.Stop();
                this.Hide();
                log.Show();
            }
        }
    }
}
