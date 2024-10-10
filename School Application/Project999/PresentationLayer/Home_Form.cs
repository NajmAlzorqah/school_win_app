using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project999.PresentationLayer
{
    public partial class Home_Form : Form
    {

        //Section Variables
        School_layes.StudentClass studentCAT = new School_layes.StudentClass();
        School_layes.GradesLayerClass gradesCAT = new School_layes.GradesLayerClass();

        School_layes.SubjectsLayerClass subjectsCAT = new School_layes.SubjectsLayerClass();
        School_layes.EnrolmentLayerClass enrollmentCAT = new School_layes.EnrolmentLayerClass();

        School_layes.ClassesLayerClass classesCAT = new School_layes.ClassesLayerClass();
        School_layes.TeachersLayerClass teachersCAT = new School_layes.TeachersLayerClass();

        School_layes.UsersLayerClass useresCAT = new School_layes.UsersLayerClass();




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
                GradesDaataGrid.Columns[6].HeaderText = "Grades ID";
                GradesDaataGrid.Columns[7].HeaderText = "Grades";
                GradesDaataGrid.Columns[8].HeaderText = "Grades Date";

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

            // Loading Data form Database
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = teachersCAT.load();
                teachersDataGrid.DataSource = dataTable;
                teachersDataGrid.Columns[0].HeaderText = "Teacher ID";
                //GradesDaataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                teachersDataGrid.Columns[1].HeaderText = "Teacher First Name";
                teachersDataGrid.Columns[2].HeaderText = "Teacher Last Name";
                teachersDataGrid.Columns[3].HeaderText = "E-mail";
                //teachersDataGrid.Columns[4].HeaderText = "Subject Name";
                //GradesDaataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            // Loading Data form Database
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = subjectsCAT.load();
                subjectsDataGrid.DataSource = dataTable;
                subjectsDataGrid.Columns[0].HeaderText = "Subject ID";

                //subjectsDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                subjectsDataGrid.Columns[1].HeaderText = "Subject Name";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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


            // Loading Data form Database
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = enrollmentCAT.load();
                enrolmentDataGrid.DataSource = dataTable;
                enrolmentDataGrid.Columns[0].HeaderText = "Student ID";

                //GradesDaataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                enrolmentDataGrid.Columns[1].HeaderText = "First Name";

                enrolmentDataGrid.Columns[2].HeaderText = "Last Name";
                enrolmentDataGrid.Columns[3].HeaderText = "Enrollment ID";
                enrolmentDataGrid.Columns[4].HeaderText = "Enrollment Date";
                enrolmentDataGrid.Columns[5].HeaderText = "Class ID";
                enrolmentDataGrid.Columns[6].HeaderText = "Class Name";
                //GradesDaataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;



                //GradesDaataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            // Loading Data form Database
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = classesCAT.load();
                classDataGrid.DataSource = dataTable;
                classDataGrid.Columns[0].HeaderText = "Class ID";
                classDataGrid.Columns[1].HeaderText = "Class Name";
                classDataGrid.Columns[2].HeaderText = "Grade Level";
                classDataGrid.Columns[3].HeaderText = "Teacher ID";
                classDataGrid.Columns[4].HeaderText = "Subject Name";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            // Loading Data form Database
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = useresCAT.load();
                UserDataGrid.DataSource = dataTable;

                UserDataGrid.Columns[0].HeaderText = "User ID";

                //GradesDaataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                UserDataGrid.Columns[1].HeaderText = "User Name";
                UserDataGrid.Columns[2].HeaderText = "Passwors Hash";
                UserDataGrid.Columns[0].HeaderText = "Roll";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

<<<<<<< HEAD
        
>>>>>>> 932a9122609725c1e0d5efb53f36f65952effc47
=======

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
<<<<<<< HEAD


        // glopal faile error message

        private void studentInsertSubBtn_Click(object sender, EventArgs e)
        {

            School_layes.StudentClass Insert = new School_layes.StudentClass();
            if (studentInsertFNtxt.Texts == "" || studentInsertLNtxt.Texts == "" || studentInsertDOBtxt.Texts == "" || studentInsertMailtxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
                //MessageBox.Show("Please fill all feilds.");
            }
            else
            {
                Insert.InsertStudent(studentInsertFNtxt.Texts, studentInsertLNtxt.Texts, studentInsertDOBtxt.Texts, studentInsertMailtxt.Texts);
                studentInsertFNtxt.Texts = "";
                studentInsertLNtxt.Texts = "";
                studentInsertDOBtxt.Texts = "";
                studentInsertMailtxt.Texts = "";
            }

        }

        private void studentUpdateSubBtn_Click(object sender, EventArgs e)
        {
            School_layes.StudentClass Update = new School_layes.StudentClass();
            if (studentUpIDtxt.Texts == "" || studentUpFNtxt.Texts == "" || studentUpLNtxt.Texts == "" || studentUpDOBtxt.Texts == "" || studentUpMailtxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.Show();
            }
            else
            {
                Update.UpdateStudent(studentUpIDtxt.Texts, studentUpFNtxt.Texts, studentUpLNtxt.Texts, studentUpDOBtxt.Texts, studentUpMailtxt.Texts);
                studentUpIDtxt.Texts = "";
                studentUpFNtxt.Texts = "";
                studentUpLNtxt.Texts = "";
                studentUpDOBtxt.Texts = "";
                studentUpMailtxt.Texts = "";
            }
        }

        private void studentDeleteSubBtn_Click(object sender, EventArgs e)
        {
            School_layes.StudentClass Delete = new School_layes.StudentClass();
            if (studentDeleteIDtxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
            }
            else
            {
                Delete.DeleteStudent(studentDeleteIDtxt.Texts);
                studentDeleteIDtxt.Texts = "";
            }

        }

        private void gradesSumbitBtn_Click(object sender, EventArgs e)
        {

            School_layes.GradesLayerClass InsertGrades = new School_layes.GradesLayerClass();
            if (gradesInsertStudentIDtxt.Texts == "" || gradesInsertClassIDtxt.Texts == "" || gradesInsertGradestxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
                //MessageBox.Show("Please fill all feilds.");
            }
            else
            {

                InsertGrades.InsertGrades(gradesInsertStudentIDtxt.Texts, gradesInsertClassIDtxt.Texts, gradesInsertGradestxt.Texts);
                gradesInsertStudentIDtxt.Texts = "";
                gradesInsertClassIDtxt.Texts = "";
                gradesInsertGradestxt.Texts = "";
            }
        }

        private void gradesUpdateSumbitBtn_Click(object sender, EventArgs e)
        {
            School_layes.GradesLayerClass UpdateGrades = new School_layes.GradesLayerClass();
            if (gradesUpdateGradeIDtxt.Texts == "" || gradesUpdateNewGradetxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
                //MessageBox.Show("Please fill all feilds.");
            }
            else
            {

                UpdateGrades.UpdateGrades(gradesUpdateGradeIDtxt.Texts, gradesUpdateNewGradetxt.Texts);

                gradesUpdateGradeIDtxt.Texts = "";
                gradesUpdateNewGradetxt.Texts = "";
            }
        }

        private void gradesDeleteSumbitBtn_Click(object sender, EventArgs e)
        {
            School_layes.GradesLayerClass DeleteGrades = new School_layes.GradesLayerClass();
            if (gradesIDDeletetxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
                //MessageBox.Show("Please fill all feilds.");
            }
            else
            {

                DeleteGrades.DeleteGrades(gradesIDDeletetxt.Texts);

                gradesIDDeletetxt.Texts = "";
            }
        }

        private void subjectsInsertSumbitBtn_Click(object sender, EventArgs e)
        {
            School_layes.SubjectsLayerClass InsertSubject = new School_layes.SubjectsLayerClass();
            if (subjectsInsertSNametxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
            }
            else
            {
                InsertSubject.InsertSubjects(subjectsInsertSNametxt.Texts);
                subjectsInsertSNametxt.Texts = "";
            }
        }

        private void subjectsUpdateSubmutBtn_Click(object sender, EventArgs e)
        {

            School_layes.SubjectsLayerClass UpdateSubject = new School_layes.SubjectsLayerClass();
            if (subjectsUpdateSIDtxt.Texts == "" || subjectsUpdateNewStxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
            }
            else
            {
                UpdateSubject.UpdateSubjects(int.Parse(subjectsUpdateSIDtxt.Texts), subjectsUpdateNewStxt.Texts);
                subjectsUpdateSIDtxt.Texts = "";
                subjectsUpdateNewStxt.Texts = "";
            }
        }

        private void subjectsDeleteSubmitBtn_Click(object sender, EventArgs e)
        {
            School_layes.SubjectsLayerClass DeleteSubject = new School_layes.SubjectsLayerClass();
            if (subjectsDeleteStudentIDtxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
            }
            else
            {
                DeleteSubject.DeleteSubjects(int.Parse(subjectsDeleteStudentIDtxt.Texts));
                subjectsDeleteStudentIDtxt.Texts = "";
            }
        }

        private void enrolmentInsertSubBtn_Click(object sender, EventArgs e)
        {
            School_layes.EnrolmentLayerClass InsertEnrolment = new School_layes.EnrolmentLayerClass();
            if (enrolmentInsertSidtxt.Texts == "" || enrolmentInsertCIdtxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
            }
            else
            {
                InsertEnrolment.InsertEnrolment(int.Parse(enrolmentInsertSidtxt.Texts), int.Parse(enrolmentInsertCIdtxt.Texts));
                enrolmentInsertSidtxt.Texts = "";
                enrolmentInsertCIdtxt.Texts = "";
            }
        }

        private void enrolmentDeleteSubBtn_Click(object sender, EventArgs e)
        {
            School_layes.EnrolmentLayerClass DeleteEnrolment = new School_layes.EnrolmentLayerClass();
            if (enrolmentDeleteIdtxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
            }
            else
            {
                DeleteEnrolment.DeleteEnrolment(int.Parse(enrolmentDeleteIdtxt.Texts));
                enrolmentDeleteIdtxt.Texts = "";
            }
        }

        private void classInsertSubBtn_Click(object sender, EventArgs e)
        {
            School_layes.ClassesLayerClass InsertClass = new School_layes.ClassesLayerClass();
            if (classInsertCNametxt.Texts == "" || classInsertLeveltxt.Texts == "" || classInsertTIdtxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
            }
            else
            {
                InsertClass.InsertClasses(classInsertCNametxt.Texts, int.Parse(classInsertLeveltxt.Texts), int.Parse(classInsertTIdtxt.Texts));
                classInsertCNametxt.Texts = "";
                classInsertLeveltxt.Texts = "";
                classInsertTIdtxt.Texts = "";

            }
        }

        private void classUpSubBtn_Click(object sender, EventArgs e)
        {
            School_layes.ClassesLayerClass UpdateClass = new School_layes.ClassesLayerClass();
            if (classUpClasstxt.Texts == "" || classUpNewClassNametxt.Texts == "" || classUpLeveltxt.Texts == "" || classUpNewTtxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
            }
            else
            {
                try
                {
                    UpdateClass.UpdateClasses(int.Parse(classUpClasstxt.Texts), classUpNewClassNametxt.Texts, int.Parse(classUpLeveltxt.Texts), int.Parse(classUpNewTtxt.Texts));
                    classUpClasstxt.Texts = "";
                    classUpNewClassNametxt.Texts = "";
                    classUpLeveltxt.Texts = "";
                    classUpNewTtxt.Texts = "";

                }
                catch
                {
                    PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Error, Wrong format.";
                    failureForm.Show();

                }

            }
        }

        private void classDeleteSubBtn_Click(object sender, EventArgs e)
        {
            School_layes.ClassesLayerClass DeleteClass = new School_layes.ClassesLayerClass();
            if (classDeletetxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
            }
            else
            {
                try
                {
                    DeleteClass.DeleteClasses(int.Parse(classDeletetxt.Texts));
                    classDeletetxt.Texts = "";

                }
                catch
                {
                    PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Error, Wrong format.";
                    failureForm.Show();

                }


            }
        }

        private void teachInsetSubBtn_Click(object sender, EventArgs e)
        {
            School_layes.TeachersLayerClass InsertTeacher = new School_layes.TeachersLayerClass();
            
            if (teachinsertFNtxt.Texts == "" || teachInsertLNtxt.Texts == "" || teachInsertmailtxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
            }
            else
            {
                    InsertTeacher.InsertTeachers(teachinsertFNtxt.Texts, teachInsertLNtxt.Texts, teachInsertmailtxt.Texts);
                    teachinsertFNtxt.Texts = "";
                    teachInsertLNtxt.Texts = "";
                    teachInsertmailtxt.Texts = "";



            }
        }

        private void teachUodateSubBtn_Click(object sender, EventArgs e)
        {
            School_layes.TeachersLayerClass UpdateTeacher = new School_layes.TeachersLayerClass();


            if (teachUpTeacIDtxt.Texts == "" || teachUpNewFNtxt.Texts == "" || teachUpNewLNtxt.Texts == "" || teachUpNewMailtxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
            }
            else
            {
                try
                {
                    UpdateTeacher.UpdateTeachers(int.Parse(teachUpTeacIDtxt.Texts), teachUpNewFNtxt.Texts, teachUpNewLNtxt.Texts, teachUpNewMailtxt.Texts);
                    teachUpTeacIDtxt.Texts = "";
                    teachUpNewFNtxt.Texts = "";
                    teachUpNewLNtxt.Texts = "";
                    teachUpNewMailtxt.Texts = "";

                }
                catch
                {
                    PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Error, Wrong format.";
                    failureForm.Show();

                }


            }
        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            School_layes.TeachersLayerClass DeleteTeacher = new School_layes.TeachersLayerClass();


            if (teachDeleteTIDtxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
            }
            else
            {
                try
                {
                    DeleteTeacher.DeleteTeachers(int.Parse(teachDeleteTIDtxt.Texts));
                    teachDeleteTIDtxt.Texts = "";

                }
                catch
                {
                    PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Error, Wrong format.";
                    failureForm.Show();

                }


            }
        }

        private void UserInsertBtn_Click(object sender, EventArgs e)
        {
            School_layes.UsersLayerClass InsertUser = new School_layes.UsersLayerClass();
            
            if (UserInsertUnametxt.Texts == "" || UserInsertPasstxt.Texts == "" || UserInsertRoltxt.Texts == "" )
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
            }
            else
            {
                try
                {
                    InsertUser.InsertUser(UserInsertUnametxt.Texts, UserInsertPasstxt.Texts, int.Parse(UserInsertRoltxt.Texts));
                    UserInsertUnametxt.Texts = "";
                    UserInsertPasstxt.Texts = "";
                    UserInsertRoltxt.Texts = "";
                }
                catch
                {
                    PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Error, Wrong format.";
                    failureForm.Show();

                }


            }
        }

        private void UserUpdateSubBtn_Click(object sender, EventArgs e)
        {
            School_layes.UsersLayerClass UpdateUser = new School_layes.UsersLayerClass();

            if (UserUpUIdtxt.Texts == "" || UserUpNNametxt.Texts == "" || UserUpNPasstxt.Texts == "" || UserUpNRolltxt.Texts == "")
            {
                PresentationLayer.FailureForm failureForm = new FailureForm();
                failureForm.FailureFormText.Text = "Failed, Please fill in all fields.";
                failureForm.Show();
            }
            else
            {
                try
                {
                    UpdateUser.UpdateUser(int.Parse(UserUpUIdtxt.Texts), UserUpNNametxt.Texts, UserUpNPasstxt.Texts, int.Parse(UserUpNRolltxt.Texts));
                    UserUpUIdtxt.Texts = "";
                    UserUpNNametxt.Texts = "";
                    UserUpNPasstxt.Texts = "";
                    UserUpNRolltxt.Texts = "";
                }
                catch
                {
                    PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Error, Wrong format.";
                    failureForm.Show();

                }


            }
        }
=======
>>>>>>> 4b708fc757eb163c36850443a9b684da87f45549
>>>>>>> 76f0cb7aeddedbc5d296d1620df5ee8283503239
    }
}
