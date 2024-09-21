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

            home_panel.Visible = true;
            student_panel.Visible = false;
            subject_panel.Visible = false;
            teacher_panel.Visible = false;
            class_panel.Visible = false;
            users_panel.Visible = false;

            // student Panels
            insert_student_panel.Visible = true;
            update_student_panel.Visible = false;
            delete_student_panel.Visible = false;


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
                // profile picture
                profile_image.Height = 25;
                profile_image.Width = 25;


                // Home Button
                //home_button.ImageAlign = ContentAlignment.MiddleLeft;
                home_button.Padding = new Padding(10, 0, 0, 0);


                // Student Button
                //student_button.ImageAlign = ContentAlignment.MiddleLeft;
                student_button.Padding = new Padding(10, 0, 0, 0);

                // Grades Button
                //grades_button.ImageAlign = ContentAlignment.MiddleLeft;
                grades_button.Padding = new Padding(10, 0, 0, 0);

                // Teacher Button
                //teacher_button.ImageAlign = ContentAlignment.MiddleLeft;
                teacher_button.Padding = new Padding(10, 0, 0, 0);


                // Subjects Button
                //subjects_button.ImageAlign = ContentAlignment.MiddleLeft;
                subjects_button.Padding = new Padding(10, 0, 0, 0);

                // Enrolment Button
                //enrolment_button.ImageAlign = ContentAlignment.MiddleLeft;
                enrolment_button.Padding = new Padding(10, 0, 0, 0);



                // Classes Button
                //classes_button.ImageAlign = ContentAlignment.MiddleLeft;
                classes_button.Padding = new Padding(10, 0, 0, 0);



                // Users Button
                //users_putton.ImageAlign = ContentAlignment.MiddleLeft;
                users_putton.Padding = new Padding(10, 0, 0, 0);

            }
            else if (left_menu.Width == 62)
            {
                left_menu.Width = 230;
                // profile Pictuer
                profile_image.Height = 90;
                profile_image.Width = 90;

                // Menu Button
                menu_button.ImageAlign = ContentAlignment.MiddleCenter;

                // Home Button
                //home_button.ImageAlign = ContentAlignment.MiddleLeft;
                home_button.Padding = new Padding(30, 0, 40, 0);
                
                // Student Button
                //student_button.ImageAlign = ContentAlignment.MiddleLeft;
                student_button.Padding = new Padding(30, 0, 40, 0);

                // Grades Button
                grades_button.Padding = new Padding(30, 0, 40, 0);


                // Teacher Button
                //teacher_button.ImageAlign = ContentAlignment.MiddleLeft;
                teacher_button.Padding = new Padding(30, 0, 40, 0);


                // Subjects Button 
                //subjects_button.ImageAlign = ContentAlignment.MiddleLeft;
                subjects_button.Padding = new Padding(30, 0, 40, 0);

                // Enrolment Button
                //enrolment_button.ImageAlign = ContentAlignment.MiddleLeft;
                enrolment_button.Padding = new Padding(30, 0, 40, 0);

                // Classes Button
                //classes_button.ImageAlign = ContentAlignment.MiddleLeft;
                classes_button.Padding = new Padding(30, 0, 40, 0);


                // Users Button
                //users_putton.ImageAlign = ContentAlignment.MiddleLeft;
                users_putton.Padding = new Padding(30, 0, 40, 0);

            }
            else
            {
                // Optionally handle cases where the width is not what you expect
                MessageBox.Show("Unexpected width value.");
            }
        }

        // //////////////////////////////////////////////////////////////////////
        
        // MENU BUTTONS
        private void home_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = true;
            student_panel.Visible = false;
            subject_panel.Visible = false;
            teacher_panel.Visible = false;
            class_panel.Visible = false;
            users_panel.Visible = false;
            grades_panel.Visible = false;
            enrolment_panel.Visible = false;
        }

        private void student_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            student_panel.Visible = true;
            subject_panel.Visible = false;
            teacher_panel.Visible = false;
            class_panel.Visible = false;
            users_panel.Visible = false;
            grades_panel.Visible = false;
            enrolment_panel.Visible = false;
        }

        private void grades_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            student_panel.Visible = false;
            subject_panel.Visible = false;
            teacher_panel.Visible = false;
            class_panel.Visible = false;
            users_panel.Visible = false;
            grades_panel.Visible = true;
            enrolment_panel.Visible = false;
        }
        private void teacher_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            student_panel.Visible = false;
            subject_panel.Visible = false;
            teacher_panel.Visible = true;
            class_panel.Visible = false;
            users_panel.Visible = false;
            grades_panel.Visible = false;
            enrolment_panel.Visible = false;
        }

        private void subjects_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            student_panel.Visible = false;
            subject_panel.Visible = true;
            teacher_panel.Visible = false;
            class_panel.Visible = false;
            users_panel.Visible = false;
            grades_panel.Visible = false;
            enrolment_panel.Visible = false;

        }

        private void enrolment_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            student_panel.Visible = false;
            subject_panel.Visible = false;
            teacher_panel.Visible = false;
            class_panel.Visible = false;
            users_panel.Visible = false;
            grades_panel.Visible = false;
            enrolment_panel.Visible = true;
        }
        private void classes_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            student_panel.Visible = false;
            subject_panel.Visible = false;
            teacher_panel.Visible = false;
            class_panel.Visible = true;
            users_panel.Visible = false;
            grades_panel.Visible = false;
            enrolment_panel.Visible = false;
        }

        private void users_putton_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            student_panel.Visible = false;
            subject_panel.Visible = false;
            teacher_panel.Visible = false;
            class_panel.Visible = false;
            users_panel.Visible = true;
            grades_panel.Visible = false;
            enrolment_panel.Visible = false;
        }
<<<<<<< HEAD

        private void left_menu_Paint(object sender, PaintEventArgs e)
        {

        }
=======
        // END
        // //////////////////////////////////////////////////////////////////////

        private void INSERT_button_Click(object sender, EventArgs e)
        {
            insert_student_panel.Visible = true;
            update_student_panel.Visible = false;
            delete_student_panel.Visible = false;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            insert_student_panel.Visible = false;
            update_student_panel.Visible = true;
            delete_student_panel.Visible = false;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            insert_student_panel.Visible = false;
            update_student_panel.Visible = false;
            delete_student_panel.Visible = true;
        }

        private void grade_insert_button_Click(object sender, EventArgs e)
        {
            grade_update_panel.Visible = false;
            grade_insert_panel.Visible = true;
            grades_delete_panel.Visible = false;
        }

        private void grade_update_button_Click(object sender, EventArgs e)
        {
            grade_update_panel.Visible = true;
            grade_insert_panel.Visible = false;
            grades_delete_panel.Visible = false;
        }

        private void grade_delete_panel_Click(object sender, EventArgs e)
        {
            grade_update_panel.Visible = false;
            grade_insert_panel.Visible = false;
            grades_delete_panel.Visible = true;
        }

        
>>>>>>> 932a9122609725c1e0d5efb53f36f65952effc47
    }
}
