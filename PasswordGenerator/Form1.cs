using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneration_Click(object sender, EventArgs e)
        {
            Random PassGen = new Random();
            StringBuilder passwd = new StringBuilder();
            int length = int.Parse(txtPasswordLength.Text);
            if (length > 25)
            {
                MessageBox.Show("Incorrect length", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < length; i++)
            {
                passwd.Append((char)PassGen.Next(50, 100));
            }
            txtPassword.Text = passwd.ToString();
        }
    }
}
