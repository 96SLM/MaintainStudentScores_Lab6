namespace MaintainStudentScores_Lab6
{
    partial class frmAddNewStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName1 = new TextBox();
            txtScore1 = new TextBox();
            txtScoresDisplay = new TextBox();
            lblName = new Label();
            lblScore = new Label();
            lblScores1 = new Label();
            btnAddScore = new Button();
            btnClearScores = new Button();
            btnCancel1 = new Button();
            btnOk1 = new Button();
            SuspendLayout();
            // 
            // txtName1
            // 
            txtName1.Location = new Point(63, 12);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(202, 23);
            txtName1.TabIndex = 0;
            // 
            // txtScore1
            // 
            txtScore1.Location = new Point(63, 52);
            txtScore1.Name = "txtScore1";
            txtScore1.Size = new Size(100, 23);
            txtScore1.TabIndex = 1;
            // 
            // txtScoresDisplay
            // 
            txtScoresDisplay.Location = new Point(63, 91);
            txtScoresDisplay.Name = "txtScoresDisplay";
            txtScoresDisplay.ReadOnly = true;
            txtScoresDisplay.Size = new Size(202, 23);
            txtScoresDisplay.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(15, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(15, 55);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(42, 15);
            lblScore.TabIndex = 4;
            lblScore.Text = " Score:";
            // 
            // lblScores1
            // 
            lblScores1.AutoSize = true;
            lblScores1.Location = new Point(15, 98);
            lblScores1.Name = "lblScores1";
            lblScores1.Size = new Size(44, 15);
            lblScores1.TabIndex = 5;
            lblScores1.Text = "Scores:";
            // 
            // btnAddScore
            // 
            btnAddScore.Location = new Point(173, 51);
            btnAddScore.Name = "btnAddScore";
            btnAddScore.Size = new Size(92, 23);
            btnAddScore.TabIndex = 6;
            btnAddScore.Text = "&Add Score";
            btnAddScore.UseVisualStyleBackColor = true;
            // 
            // btnClearScores
            // 
            btnClearScores.Location = new Point(173, 123);
            btnClearScores.Name = "btnClearScores";
            btnClearScores.Size = new Size(92, 23);
            btnClearScores.TabIndex = 7;
            btnClearScores.Text = "Clear &Scores";
            btnClearScores.UseVisualStyleBackColor = true;
            // 
            // btnCancel1
            // 
            btnCancel1.Location = new Point(173, 152);
            btnCancel1.Name = "btnCancel1";
            btnCancel1.Size = new Size(92, 23);
            btnCancel1.TabIndex = 8;
            btnCancel1.Text = "&Cancel";
            btnCancel1.UseVisualStyleBackColor = true;
            // 
            // btnOk1
            // 
            btnOk1.Location = new Point(63, 152);
            btnOk1.Name = "btnOk1";
            btnOk1.Size = new Size(92, 23);
            btnOk1.TabIndex = 9;
            btnOk1.Text = "&Ok";
            btnOk1.UseVisualStyleBackColor = true;
            btnOk1.Click += btnOk1_Click;
            // 
            // frmAddNewStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel1;
            ClientSize = new Size(292, 192);
            Controls.Add(btnOk1);
            Controls.Add(btnCancel1);
            Controls.Add(btnClearScores);
            Controls.Add(btnAddScore);
            Controls.Add(lblScores1);
            Controls.Add(lblScore);
            Controls.Add(lblName);
            Controls.Add(txtScoresDisplay);
            Controls.Add(txtScore1);
            Controls.Add(txtName1);
            Name = "frmAddNewStudent";
            Text = "Add New Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName1;
        private TextBox txtScore1;
        private TextBox txtScoresDisplay;
        private Label lblName;
        private Label lblScore;
        private Label lblScores1;
        private Button btnAddScore;
        private Button btnClearScores;
        private Button btnCancel1;
        private Button btnOk1;
    }
}