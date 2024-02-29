namespace MaintainStudentScores_Lab6
{
    partial class frmStudentScores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtScoreTotal = new TextBox();
            txtScoreCount = new TextBox();
            txtAverage = new TextBox();
            lblStudents = new Label();
            lblScoreTotal = new Label();
            lblScoreCount = new Label();
            lblAverage = new Label();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            lstStudents = new ListBox();
            SuspendLayout();
            // 
            // txtScoreTotal
            // 
            txtScoreTotal.Location = new Point(203, 163);
            txtScoreTotal.Name = "txtScoreTotal";
            txtScoreTotal.ReadOnly = true;
            txtScoreTotal.Size = new Size(56, 23);
            txtScoreTotal.TabIndex = 1;
            // 
            // txtScoreCount
            // 
            txtScoreCount.Location = new Point(203, 195);
            txtScoreCount.Name = "txtScoreCount";
            txtScoreCount.ReadOnly = true;
            txtScoreCount.Size = new Size(56, 23);
            txtScoreCount.TabIndex = 2;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(203, 229);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(56, 23);
            txtAverage.TabIndex = 3;
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Location = new Point(12, 20);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(59, 15);
            lblStudents.TabIndex = 4;
            lblStudents.Text = "Students: ";
            // 
            // lblScoreTotal
            // 
            lblScoreTotal.AutoSize = true;
            lblScoreTotal.Location = new Point(130, 166);
            lblScoreTotal.Name = "lblScoreTotal";
            lblScoreTotal.Size = new Size(67, 15);
            lblScoreTotal.TabIndex = 5;
            lblScoreTotal.Text = "Score Total:";
            lblScoreTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblScoreCount
            // 
            lblScoreCount.AutoSize = true;
            lblScoreCount.Location = new Point(119, 198);
            lblScoreCount.Name = "lblScoreCount";
            lblScoreCount.Size = new Size(75, 15);
            lblScoreCount.TabIndex = 6;
            lblScoreCount.Text = "Score Count:";
            lblScoreCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(141, 232);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(53, 15);
            lblAverage.TabIndex = 7;
            lblAverage.Text = "Average:";
            lblAverage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(287, 37);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 8;
            btnAddNew.Text = "&Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(287, 66);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(287, 95);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(287, 224);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(20, 48);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(239, 109);
            lstStudents.TabIndex = 0;
            // 
            // frmStudentScores
            // 
            AcceptButton = btnAddNew;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(380, 267);
            Controls.Add(lstStudents);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(lblAverage);
            Controls.Add(lblScoreCount);
            Controls.Add(lblScoreTotal);
            Controls.Add(lblStudents);
            Controls.Add(txtAverage);
            Controls.Add(txtScoreCount);
            Controls.Add(txtScoreTotal);
            Name = "frmStudentScores";
            Text = "Student Scores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtScoreTotal;
        private TextBox txtScoreCount;
        private TextBox txtAverage;
        private Label lblStudents;
        private Label lblScoreTotal;
        private Label lblScoreCount;
        private Label lblAverage;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private ListBox lstStudents;
    }
}
