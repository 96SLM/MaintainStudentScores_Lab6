namespace MaintainStudentScores_Lab6
{
    partial class frnUpdateScore
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
            txtScore3 = new TextBox();
            btnUpdate = new Button();
            btnCancel4 = new Button();
            lblScore3 = new Label();
            SuspendLayout();
            // 
            // txtScore3
            // 
            txtScore3.Location = new Point(71, 23);
            txtScore3.Name = "txtScore3";
            txtScore3.Size = new Size(100, 23);
            txtScore3.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(15, 52);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCancel4
            // 
            btnCancel4.Location = new Point(96, 52);
            btnCancel4.Name = "btnCancel4";
            btnCancel4.Size = new Size(75, 23);
            btnCancel4.TabIndex = 2;
            btnCancel4.Text = "&Cancel";
            btnCancel4.UseVisualStyleBackColor = true;
            // 
            // lblScore3
            // 
            lblScore3.AutoSize = true;
            lblScore3.Location = new Point(15, 23);
            lblScore3.Name = "lblScore3";
            lblScore3.Size = new Size(42, 15);
            lblScore3.TabIndex = 3;
            lblScore3.Text = "Score: ";
            // 
            // frnUpdateScore
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel4;
            ClientSize = new Size(206, 93);
            Controls.Add(lblScore3);
            Controls.Add(btnCancel4);
            Controls.Add(btnUpdate);
            Controls.Add(txtScore3);
            Name = "frnUpdateScore";
            Text = "Update Score";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtScore3;
        private Button btnUpdate;
        private Button btnCancel4;
        private Label lblScore3;
    }
}