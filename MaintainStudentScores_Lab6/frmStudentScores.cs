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
        public List<String> students = new List<String>();
        
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
        private void ReloadStudentListBox(String student)
        {
            lstStudents.Items.Add(student);
        }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form frmUpdateStudentScores = new frmUpdateStudentScores();
            DialogResult = frmUpdateStudentScores.ShowDialog();

            if (DialogResult == DialogResult.OK)
            {

                ReloadStudentListBox(students.Last());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstStudents.SelectedItem = null;

            
        }
    }
}
