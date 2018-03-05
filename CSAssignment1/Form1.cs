using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAssignment1
{
    public partial class Form1 : Form
    {

        private LinkedList<Student> studentList = null;
        private LinkedListNode<Student> currNode = null;
        Student student = new Student();
        private Queue<Test> testQueue = null;

        public Form1()
        {
            studentList = new LinkedList<Student>();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Btn_Click_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = null ;
                foreach (var studentObj in studentList)
                {
                    if (studentObj.Name.Contains(textName.Text))
                    {
                        student = studentObj;
                    }
                }

                if (student != null) // Student already exists
                {
                    Test test = new Test();
                    test.TestID = int.Parse(textId.Text);
                    test.ObtainedScore = double.Parse(textScore.Text);
                    test.MaximumScore = double.Parse(textMaxScore.Text);
                    student.addTest(test);
                    lblMessage.Text = "Student exists. Test info. added";
                } else
                { // Student do not exist
                    student = new Student();
                    student.Name = textName.Text;
                    Test test = new Test();
                    test.TestID = int.Parse(textId.Text);
                    test.ObtainedScore = double.Parse(textScore.Text);
                    test.MaximumScore = double.Parse(textMaxScore.Text);
                    student.addTest(test);
                    studentList.AddLast(student);
                    lblMessage.Text = "Student and Test added";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void display_Btn_Click_Click(object sender, EventArgs e)
        {
            stu_List.Items.Clear();
            foreach(var studentDetails in studentList)
            {
                stu_List.Items.Add(studentDetails.ToString());
                Queue<Test> allTests = studentDetails.getAllTest();
                foreach (var testDetail in allTests)
                {
                    stu_List.Items.Add(testDetail.ToString());

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void remove_Btn_Click_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = null;
                foreach (var studentObj in studentList)
                {
                    if (studentObj.Name.Contains(textName.Text))
                    {
                        student = studentObj;
                    }
                }

                if (student != null) // Student already exists
                {
                    student.removeTest(int.Parse(textId.Text));
                    lblMessage.Text = "Student exists. Test info. removed";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = null;
                foreach (var studentObj in studentList)
                {
                    if (studentObj.Name.Contains(textName.Text))
                    {
                        student = studentObj;
                    }
                }

                if (student != null) // Student already exists
                {
                    Test test = new Test();
                    test.TestID = int.Parse(textId.Text);
                    test.ObtainedScore = double.Parse(textScore.Text);
                    test.MaximumScore = double.Parse(textMaxScore.Text);
                    student.updateTest(test);
                    lblMessage.Text = "Student exists. Test info. updated";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
