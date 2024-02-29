namespace MaintainStudentScores_Lab6
{
    partial class frnAddScore
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
            txtScore2 = new TextBox();
            btnCancel3 = new Button();
            btnAdd2 = new Button();
            lblScore = new Label();
            SuspendLayout();
            // 
            // txtScore2
            // 
            txtScore2.Location = new Point(75, 23);
            txtScore2.Name = "txtScore2";
            txtScore2.Size = new Size(100, 23);
            txtScore2.TabIndex = 0;
            // 
            // btnCancel3
            // 
            btnCancel3.Location = new Point(100, 52);
            btnCancel3.Name = "btnCancel3";
            btnCancel3.Size = new Size(75, 23);
            btnCancel3.TabIndex = 1;
            btnCancel3.Text = "&Cancel";
            btnCancel3.UseVisualStyleBackColor = true;
            // 
            // btnAdd2
            // 
            btnAdd2.Location = new Point(15, 52);
            btnAdd2.Name = "btnAdd2";
            btnAdd2.Size = new Size(75, 23);
            btnAdd2.TabIndex = 2;
            btnAdd2.Text = "&Add";
            btnAdd2.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(15, 23);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(42, 15);
            lblScore.TabIndex = 3;
            lblScore.Text = "Score: ";
            // 
            // frnAddScore
            // 
            AcceptButton = btnAdd2;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel3;
            ClientSize = new Size(200, 97);
            Controls.Add(lblScore);
            Controls.Add(btnAdd2);
            Controls.Add(btnCancel3);
            Controls.Add(txtScore2);
            Name = "frnAddScore";
            Text = "Add Score";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtScore2;
        private Button btnCancel3;
        private Button btnAdd2;
        private Label lblScore;
    }
}