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
    public partial class Home_Form : Form
    {
        public Home_Form()
        {
            InitializeComponent();
            setwidth2();
        }
        public void setwidth2()
        {
            left_menu.Width = 230;
            menu_button.FlatAppearance.MouseOverBackColor = menu_button.BackColor;
            menu_button.FlatAppearance.MouseDownBackColor = menu_button.BackColor;
        }

        private void Home_Form_Load(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            
            if (left_menu.Width == 230)
            {
                left_menu.Width = 62;
                
                // Home Button
                home_button.ImageAlign = ContentAlignment.MiddleLeft;
                home_button.Padding = new Padding(10, 0, 0, 0);


                // Student Button
                student_button.ImageAlign = ContentAlignment.MiddleLeft;
                student_button.Padding = new Padding(10, 0, 0, 0);


                // Teacher Button
                teacher_button.ImageAlign = ContentAlignment.MiddleLeft;
                teacher_button.Padding = new Padding(10, 0, 0, 0);



                // Subjects Button
                subjects_button.ImageAlign = ContentAlignment.MiddleLeft;
                subjects_button.Padding = new Padding(10, 0, 0, 0);



                // Classes Button
                classes_button.ImageAlign = ContentAlignment.MiddleLeft;
                classes_button.Padding = new Padding(10, 0, 0, 0);



                // Users Button
                users_putton.ImageAlign = ContentAlignment.MiddleLeft;
                users_putton.Padding = new Padding(10, 0, 0, 0);

            }
            else if (left_menu.Width == 62)
            {
                left_menu.Width = 230;
                // Menu Button
                menu_button.ImageAlign = ContentAlignment.MiddleCenter;

                // Home Button
                home_button.ImageAlign = ContentAlignment.MiddleLeft;
                home_button.Padding = new Padding(30, 0, 40, 0);
                
                // Student Button
                student_button.ImageAlign = ContentAlignment.MiddleLeft;
                student_button.Padding = new Padding(30, 0, 40, 0);

                // Teacher Button
                teacher_button.ImageAlign = ContentAlignment.MiddleLeft;
                teacher_button.Padding = new Padding(30, 0, 40, 0);


                // Subjects Button 
                subjects_button.ImageAlign = ContentAlignment.MiddleLeft;
                subjects_button.Padding = new Padding(30, 0, 40, 0);


                // Classes Button
                classes_button.ImageAlign = ContentAlignment.MiddleLeft;
                classes_button.Padding = new Padding(30, 0, 40, 0);


                // Users Button
                users_putton.ImageAlign = ContentAlignment.MiddleLeft;
                users_putton.Padding = new Padding(30, 0, 40, 0);

            }
            else
            {
                // Optionally handle cases where the width is not what you expect
                MessageBox.Show("Unexpected width value.");
            }
        }


        private void home_button_Click(object sender, EventArgs e)
        {

        }

        private void student_button_Click(object sender, EventArgs e)
        {
            //student_button.FlatAppearance.MouseOverBackColor = student_button.BackColor;
            //student_button.FlatAppearance.MouseDownBackColor = student_button.BackColor;
            //courses_button.Text = "ddddddddddddd";
        }

        private void teacher_button_Click(object sender, EventArgs e)
        {
            
        }

        private void subjects_button_Click(object sender, EventArgs e)
        {

        }

        private void classes_button_Click(object sender, EventArgs e)
        {

        }

        private void users_putton_Click(object sender, EventArgs e)
        {

        }
    }
}
