using StudentInfoApplication.studentNamespace;

namespace StudentInfoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                int studentID = int.Parse(studentIDtxt.Text); 
                string firstName = firstNametxt.Text;
                string lastName = lastNametxt.Text;

               
                StudentInfo student = new StudentInfo(studentID, firstName, lastName);

                listStudentID.Items.Add(student.StudentID.ToString()); 
                listFirstName.Items.Add(student.FirstName);            
                listLastName.Items.Add(student.LastName);              
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Please enter a valid numeric Student ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    namespace studentNamespace
    {
        public class StudentInfo
        {
            
            private int studentID;
            private string firstName;
            private string lastName;

            // Overloaded Constructors
            public StudentInfo()
            {
                studentID = 0;
                firstName = string.Empty;
                lastName = string.Empty;
            }

            
            public StudentInfo(int id)
            {
                studentID = id;
                firstName = string.Empty;
                lastName = string.Empty;
            }

          
            public StudentInfo(int id, string fName, string lName)
            {
                this.studentID = id;
                this.firstName = fName;
                this.lastName = lName;
            }

            // Properties
            public int StudentID
            {
                get { return studentID; }
                set { studentID = value; }
            }

           
            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            
            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            // Method to return student information 
            public string GetStudentInfo()
            {
                return $"ID: {studentID}, First Name: {firstName}, Last Name: {lastName}";
            }
        }
    }
}