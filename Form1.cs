using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "admin" && txtpassword.Text == "admin123")
            {
                MessageBox.Show("Login success");
                MDI mdi = new MDI();
                mdi.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("login faild");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtpassword.Clear();
        }
    }
}
