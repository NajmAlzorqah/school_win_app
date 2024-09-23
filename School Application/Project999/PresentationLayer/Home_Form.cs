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

        // Students Section Variables
        School_layes.StudentClass studentCAT = new School_layes.StudentClass();
        School_layes.GradesLayerClass gradesCAT = new School_layes.GradesLayerClass();




        public Home_Form()
        {
            InitializeComponent();
            setwidth2();

            home_panel.Visible = true;
            StudentMainPanel.Visible = false;
            SubjectsPanel.Visible = false;
            TeacherPanel.Visible = false;
            ClassesPanel.Visible = false;
            UsersPanel.Visible = false;
            GradesPanel.Visible = false;
            EnrolmentPanel.Visible = false;

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
                home_button.Padding = new Padding(10, 0, 0, 0);

                // Student Button
                student_button.Padding = new Padding(10, 0, 0, 0);

                // Grades Button
                grades_button.Padding = new Padding(10, 0, 0, 0);

                // Teacher Button
                teacher_button.Padding = new Padding(10, 0, 0, 0);

                // Subjects Button
                subjects_button.Padding = new Padding(10, 0, 0, 0);

                // Enrolment Button
                enrolment_button.Padding = new Padding(10, 0, 0, 0);

                // Classes Button
                classes_button.Padding = new Padding(10, 0, 0, 0);

                // Users Button
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
                home_button.Padding = new Padding(30, 0, 40, 0);
                
                // Student Button
                student_button.Padding = new Padding(30, 0, 40, 0);

                // Grades Button
                grades_button.Padding = new Padding(30, 0, 40, 0);


                // Teacher Button
                teacher_button.Padding = new Padding(30, 0, 40, 0);


                // Subjects Button 
                subjects_button.Padding = new Padding(30, 0, 40, 0);

                // Enrolment Button
                enrolment_button.Padding = new Padding(30, 0, 40, 0);

                // Classes Button
                classes_button.Padding = new Padding(30, 0, 40, 0);


                // Users Button
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
            StudentMainPanel.Visible = false;
            SubjectsPanel.Visible = false;
            TeacherPanel.Visible = false;
            ClassesPanel.Visible = false;
            UsersPanel.Visible = false;
            GradesPanel.Visible = false;
            EnrolmentPanel.Visible = false;

        }

        private void student_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            StudentMainPanel.Visible = true;
            SubjectsPanel.Visible = false;
            TeacherPanel.Visible = false;
            ClassesPanel.Visible = false;
            UsersPanel.Visible = false;
            GradesPanel.Visible = false;
            EnrolmentPanel.Visible = false;

            // Loading Data form Database
            try
            {
            DataTable dataTable = new DataTable();
            dataTable = studentCAT.load();
            studentDataGrid.DataSource = dataTable;
            studentDataGrid.Columns[0].HeaderText = "Student ID";
            //studentDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            studentDataGrid.Columns[1].HeaderText = "First Name";
            //studentDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            studentDataGrid.Columns[2].HeaderText = "Last Name";
            studentDataGrid.Columns[3].HeaderText = "Date of Birth";
            studentDataGrid.Columns[4].HeaderText = "E-mail";
            studentDataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void grades_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            StudentMainPanel.Visible = false;
            SubjectsPanel.Visible = false;
            TeacherPanel.Visible = false;
            ClassesPanel.Visible = false;
            UsersPanel.Visible = false;
            GradesPanel.Visible = true;
            EnrolmentPanel.Visible = false;


            // Loading Data form Database
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = gradesCAT.load();
                GradesDaataGrid.DataSource = dataTable;
                GradesDaataGrid.Columns[0].HeaderText = "Student ID";
                //GradesDaataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                GradesDaataGrid.Columns[1].HeaderText = "First Name";
                

                GradesDaataGrid.Columns[2].HeaderText = "Last Name";
                GradesDaataGrid.Columns[3].HeaderText = "Class Name";
                GradesDaataGrid.Columns[4].HeaderText = "Class ID";
                //GradesDaataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                GradesDaataGrid.Columns[5].HeaderText = "Subject Name";
                GradesDaataGrid.Columns[6].HeaderText = "Grades";
                GradesDaataGrid.Columns[7].HeaderText = "Grades Date";

                //GradesDaataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void teacher_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            StudentMainPanel.Visible = false;
            SubjectsPanel.Visible = false;
            TeacherPanel.Visible = true;
            ClassesPanel.Visible = false;
            UsersPanel.Visible = false;
            GradesPanel.Visible = false;
            EnrolmentPanel.Visible = false;
        }

        private void subjects_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            StudentMainPanel.Visible = false;
            SubjectsPanel.Visible = true;
            TeacherPanel.Visible = false;
            ClassesPanel.Visible = false;
            UsersPanel.Visible = false;
            GradesPanel.Visible = false;
            EnrolmentPanel.Visible = false;

        }

        private void enrolment_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            StudentMainPanel.Visible = false;
            SubjectsPanel.Visible = false;
            TeacherPanel.Visible = false;
            ClassesPanel.Visible = false;
            UsersPanel.Visible = false;
            GradesPanel.Visible = false;
            EnrolmentPanel.Visible = true;
        }
        private void classes_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            StudentMainPanel.Visible = false;
            SubjectsPanel.Visible = false;
            TeacherPanel.Visible = false;
            ClassesPanel.Visible = true;
            UsersPanel.Visible = false;
            GradesPanel.Visible = false;
            EnrolmentPanel.Visible = false;
        }

        private void users_putton_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            StudentMainPanel.Visible = false;
            SubjectsPanel.Visible = false;
            TeacherPanel.Visible = false;
            ClassesPanel.Visible = false;
            UsersPanel.Visible = true;
            GradesPanel.Visible = false;
            EnrolmentPanel.Visible = false;
        }
        // END
        // //////////////////////////////////////////////////////////////////////

        private void INSERT_button_Click(object sender, EventArgs e)
        {
            //insert_student_panel.Visible = true;
            //update_student_panel.Visible = false;
            //delete_student_panel.Visible = false;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            //insert_student_panel.Visible = false;
            //update_student_panel.Visible = true;
            //delete_student_panel.Visible = false;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            //insert_student_panel.Visible = false;
            //update_student_panel.Visible = false;
            //delete_student_panel.Visible = true;
        }

        private void grade_insert_button_Click(object sender, EventArgs e)
        {
            //grade_update_panel.Visible = false;
            //grade_insert_panel.Visible = true;
            //grades_delete_panel.Visible = false;
        }

        private void grade_update_button_Click(object sender, EventArgs e)
        {
            //grade_update_panel.Visible = true;
            //grade_insert_panel.Visible = false;
            //grades_delete_panel.Visible = false;
        }

        private void grade_delete_panel_Click(object sender, EventArgs e)
        {
            //grade_update_panel.Visible = false;
            //grade_insert_panel.Visible = false;
            //grades_delete_panel.Visible = true;
        }


        private void subjectsAddBtn_Click(object sender, EventArgs e)
        {
            subjectsInsertPanel.Visible = true;
            subjectsUpdatePanel.Visible = false;
            subjectsDeletePanel.Visible = false;
        }

        private void subjectsUpdateBtn_Click(object sender, EventArgs e)
        {
            subjectsInsertPanel.Visible = false;
            subjectsUpdatePanel.Visible = true;
            subjectsDeletePanel.Visible = false;
        }

        private void subjectsDeleteBtn_Click(object sender, EventArgs e)
        {
            subjectsInsertPanel.Visible = false;
            subjectsUpdatePanel.Visible = false;
            subjectsDeletePanel.Visible = true;
        }

        private void studentInsertBtn_Click(object sender, EventArgs e)
        {
            InsertStudentPanel.Visible = true;
            UpdateStudentPanel.Visible = false;
            DeleteStudentPanel.Visible = false;
        }

        private void studentUpdateBtn_Click(object sender, EventArgs e)
        {
            InsertStudentPanel.Visible = false;
            UpdateStudentPanel.Visible = true;
            DeleteStudentPanel.Visible = false;
        }

        private void studentDeleteBtn_Click(object sender, EventArgs e)
        {
            InsertStudentPanel.Visible = false;
            UpdateStudentPanel.Visible = false;
            DeleteStudentPanel.Visible = true;
        }

        private void gradesAddBtn_Click(object sender, EventArgs e)
        {
            gradesInsertPanel.Visible = true;
            gradesUpdatePanel.Visible = false;
            gradesDeletePanel.Visible = false;
        }

        private void gradesUpdateBtn_Click(object sender, EventArgs e)
        {
            gradesInsertPanel.Visible = false;
            gradesUpdatePanel.Visible = true;
            gradesDeletePanel.Visible = false;
        }

        private void gradesDeleteBtn_Click(object sender, EventArgs e)
        {
            gradesInsertPanel.Visible = false;
            gradesUpdatePanel.Visible = false;
            gradesDeletePanel.Visible = true;
        }

        private void enrolmentAddBtn_Click(object sender, EventArgs e)
        {
            enrolmentInsertPanel.Visible = true;
            enrolmentDeletePanle.Visible = false;
        }

        private void enrolmentDeleteBtn_Click(object sender, EventArgs e)
        {
            enrolmentInsertPanel.Visible = false;
            enrolmentDeletePanle.Visible = true;
        }

        private void classAddBtn_Click(object sender, EventArgs e)
        {
            classInsertPanel.Visible = true;
            classUpdatePanel.Visible = false;
            classDeletePanel.Visible = false;
        }

        private void classUpdateBtn_Click(object sender, EventArgs e)
        {
            classInsertPanel.Visible = false;
            classUpdatePanel.Visible = true;
            classDeletePanel.Visible = false;
        }

        private void classDeleteBtn_Click(object sender, EventArgs e)
        {
            classInsertPanel.Visible = false;
            classUpdatePanel.Visible = false;
            classDeletePanel.Visible = true;
        }

        private void UserAddBtn_Click(object sender, EventArgs e)
        {
            UserInsertPanel.Visible = true;
            UserUpdatePanel.Visible = false;
            UserDeletePanel.Visible = false;

        }

        private void UserUpdateBtn_Click(object sender, EventArgs e)
        {
            UserInsertPanel.Visible = false;
            UserUpdatePanel.Visible = true;
            UserDeletePanel.Visible = false;
        }

        private void UserDeleteBtn_Click(object sender, EventArgs e)
        {
            UserInsertPanel.Visible = false;
            UserUpdatePanel.Visible = false;
            UserDeletePanel.Visible = true;
        }

        private void teachAddBtn_Click(object sender, EventArgs e)
        {
            teachInsertPanel.Visible = true;
            teachUpdatePanel.Visible = false;
            teachDeletePanel.Visible = false;
        }

        private void teachUpdateBtn_Click(object sender, EventArgs e)
        {
            teachInsertPanel.Visible = false;
            teachUpdatePanel.Visible = true;
            teachDeletePanel.Visible = false;
        }

        private void teachDeleteBtn_Click(object sender, EventArgs e)
        {
            teachInsertPanel.Visible = false;
            teachUpdatePanel.Visible = false;
            teachDeletePanel.Visible = true;
        }
    }
}
