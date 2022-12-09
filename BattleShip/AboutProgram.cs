using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class AboutProgram : Form
    {
        public AboutProgram()
        {
            InitializeComponent();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            Hide();
            start.Show();
        }
    }
}
