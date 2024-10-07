
using EmployeeApplication.EmployeeNameSpace;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            DataGrid.ColumnCount = 4;
            DataGrid.Columns[0].Name = "Employee ID";
            DataGrid.Columns[1].Name = "First Name";
            DataGrid.Columns[2].Name = "Last Name";
            DataGrid.Columns[3].Name = "Position";

           
            DataGrid.Columns[0].Width = 80;
            DataGrid.Columns[1].Width = 80;
            DataGrid.Columns[2].Width = 80;
            DataGrid.Columns[3].Width = 80;
        }



        private void SubmitBtn_Click(object sender, EventArgs e)
        {
           
            int employeeID = int.Parse(EmployeeIDtxt.Text);
            string firstName = FirstNametxt.Text;
            string lastName = LastNametxt.Text;
            string position = Positiontxt.Text;

           
            Employee newEmployee = new Employee(employeeID, firstName, lastName, position);

           
            string[] row = new string[]
            {
                newEmployee.EmployeeID.ToString(),
                newEmployee.FirstName,
                newEmployee.LastName,
                newEmployee.Position
            };

            DataGrid.Rows.Add(row); 

            
            ClearTextFields();
        }

        
        private void ClearTextFields()
        {
            EmployeeIDtxt.Clear();
            FirstNametxt.Clear();
            LastNametxt.Clear();
            Positiontxt.Clear();
        }
    }

    namespace EmployeeNameSpace
    {
        public class Employee
        {
            
            private int employeeID;      
            private string firstName;     
            private string lastName;      
            private string position;       

           
            public int EmployeeID
            {
                get { return employeeID; } 
                set { employeeID = value; } 
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

            public string Position
            {
                get { return position; } 
                set { position = value; }
            }

           
            public Employee(int employeeID, string firstName, string lastName, string position)
            {
                this.employeeID = employeeID;
                this.firstName = firstName;
                this.lastName = lastName;
                this.position = position;
            }
        }
    }
}
