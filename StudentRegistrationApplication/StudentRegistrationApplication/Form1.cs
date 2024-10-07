using Microsoft.VisualBasic.Devices;
using System.Xml.Linq;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Overloaded methods with parameters
        private void DisplayInfo(string firstName, string middleName, string lastName)
        {
            string fullName = $"{firstName} {middleName} {lastName}";
            MessageBox.Show($"Full Name: {fullName}", "Student Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayInfo(string firstName, string middleName, string lastName, string gender)
        {
            string fullName = $"{firstName} {middleName} {lastName}";
            MessageBox.Show($"Full Name: {fullName}\nGender: {gender}", "Student Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayInfo(string firstName, string middleName, string lastName, string gender, string dob, string course)
        {
            string fullName = $"{firstName} {middleName} {lastName}";
            MessageBox.Show($"Full Name: {fullName}\nGender: {gender}\nDate of Birth: {dob}\nCourse: {course}", "Student Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //The button that shows the entered information in a message box
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstName.Text;
            string middleName = MiddleName.Text;
            string lastName = LastName.Text;
            string gender = radioButton1.Checked ? "Male" : radioButton2.Checked ? "Female" : "Not Selected";
            string dob = $"{DOBDay.Text} {DOBMonth.Text}, {DOBYear.Text}";
            string course = courseName.Text;

            DisplayInfo(firstName, middleName, lastName, gender, dob, course);
            
        }

        //The browse button for the profile pictures
        private void browse_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; 

            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

               
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
