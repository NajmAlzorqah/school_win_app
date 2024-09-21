using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project999.PresentationLayer
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            new Home_Form().Show();
            //InitializeComponent();
        }


        

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string username = txt_username.Texts;
            string password = txt_password.Texts;
            if (username == "Admin" && password == "Admin")
            {
                this.Hide();
                new Home_Form().Show();
            }
            else
            {
                if (username != "Admin")
                    Error_laple.Text = "* Pleas Enter the correct Username";
                else if (password != "Admin")
                    Error_laple.Text = "* Pleas Enter the correct Password";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
