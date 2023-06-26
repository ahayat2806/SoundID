using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
        }

        private void Popup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            SoundID.Properties.Settings.Default.Key = "";
            SoundID.Properties.Settings.Default.Save();
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
