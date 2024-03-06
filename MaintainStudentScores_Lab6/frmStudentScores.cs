namespace MaintainStudentScores_Lab6
{
    public partial class frmStudentScores : Form
    {
        public frmStudentScores()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //creates a list of strings called students
        public List<String> students = new List<String>();
       // public decimal[] scoreArr = new Array();
        
        //clears form
        private void frmStudentScores_Load(object sender, EventArgs e)
        {
            students.Clear();
            if (lstStudents.Items.Count == 0)
            {
                txtScoreCount.Clear();
                txtScoreTotal.Clear();
                txtAverage.Clear();
            }
        }

        //a method to reload list box
        private void ReloadStudentListBox(String student)
        {
            lstStudents.Items.Add(student);
        }

        //code for the addNew button
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form addNewStudent = new frmAddNewStudent();
            DialogResult = addNewStudent.ShowDialog();

            if (DialogResult == DialogResult.OK)
            {
                students.Add(addNewStudent.Tag.ToString());
                ReloadStudentListBox(students.Last());
            }
        }

        //code for the update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form updateStudentScores = new frmUpdateStudentScores();
            DialogResult = updateStudentScores.ShowDialog();

            if (DialogResult == DialogResult.OK)
            {
                //fix code
                students.Add(updateStudentScores.Tag.ToString());
                ReloadStudentListBox(students.Last());
            }
        }

        //code for the delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {

            MessageBox.Show("\'Delete\' does not function currently", "Cannot Delete");
            /*
            students.RemoveAt(lstStudents.SelectedIndex);
            lstStudents.ClearSelected();
            ReloadStudentListBox(students[0]);
            */
           
        }
    }
}
