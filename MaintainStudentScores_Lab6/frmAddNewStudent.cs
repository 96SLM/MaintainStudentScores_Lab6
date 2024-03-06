using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintainStudentScores_Lab6
{
    public partial class frmAddNewStudent : Form
    {
        public frmAddNewStudent()
        {
            InitializeComponent();
        }

        private void btnOk1_Click(object sender, EventArgs e)
        {
            string items = txtName1.Text.Trim() + "||" + txtScoresDisplay.Text.Replace(" ", "||");
            Tag = items;
            DialogResult = DialogResult.OK;
        }

        private void btnAddScore_Click(object sender, EventArgs e)

        {
            txtScoresDisplay.Text += txtScore1.Text + " ";
            txtScore1.Clear();
            txtScore1.Focus();
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            txtScoresDisplay.Clear();
            txtScore1.Focus();
        }
    }
}
