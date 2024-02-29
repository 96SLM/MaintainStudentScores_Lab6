namespace MaintainStudentScores_Lab6
{
    partial class frmUpdateStudentScores
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
            txtName2 = new TextBox();
            lblName = new Label();
            lblScores2 = new Label();
            btnAdd1 = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnClearScores = new Button();
            btnCancel2 = new Button();
            btnOk2 = new Button();
            lstScores = new ListBox();
            SuspendLayout();
            // 
            // txtName2
            // 
            txtName2.Location = new Point(92, 11);
            txtName2.Name = "txtName2";
            txtName2.ReadOnly = true;
            txtName2.Size = new Size(276, 23);
            txtName2.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(27, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name: ";
            // 
            // lblScores2
            // 
            lblScores2.AutoSize = true;
            lblScores2.Location = new Point(27, 48);
            lblScores2.Name = "lblScores2";
            lblScores2.Size = new Size(44, 15);
            lblScores2.TabIndex = 3;
            lblScores2.Text = "Scores:";
            // 
            // btnAdd1
            // 
            btnAdd1.Location = new Point(293, 38);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.Size = new Size(110, 23);
            btnAdd1.TabIndex = 4;
            btnAdd1.Text = "&Add";
            btnAdd1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(293, 67);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(293, 96);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(110, 23);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "&Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnClearScores
            // 
            btnClearScores.Location = new Point(293, 129);
            btnClearScores.Name = "btnClearScores";
            btnClearScores.Size = new Size(110, 23);
            btnClearScores.TabIndex = 7;
            btnClearScores.Text = "Clear &Scores";
            btnClearScores.UseVisualStyleBackColor = true;
            // 
            // btnCancel2
            // 
            btnCancel2.Location = new Point(293, 177);
            btnCancel2.Name = "btnCancel2";
            btnCancel2.Size = new Size(110, 23);
            btnCancel2.TabIndex = 8;
            btnCancel2.Text = "&Cancel";
            btnCancel2.UseVisualStyleBackColor = true;
            // 
            // btnOk2
            // 
            btnOk2.Location = new Point(159, 177);
            btnOk2.Name = "btnOk2";
            btnOk2.Size = new Size(110, 23);
            btnOk2.TabIndex = 9;
            btnOk2.Text = "&Ok";
            btnOk2.UseVisualStyleBackColor = true;
            // 
            // lstScores
            // 
            lstScores.FormattingEnabled = true;
            lstScores.ItemHeight = 15;
            lstScores.Location = new Point(92, 48);
            lstScores.Name = "lstScores";
            lstScores.Size = new Size(177, 124);
            lstScores.TabIndex = 1;
            // 
            // frmUpdateStudentScores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel2;
            ClientSize = new Size(485, 230);
            Controls.Add(lstScores);
            Controls.Add(btnOk2);
            Controls.Add(btnCancel2);
            Controls.Add(btnClearScores);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd1);
            Controls.Add(lblScores2);
            Controls.Add(lblName);
            Controls.Add(txtName2);
            Name = "frmUpdateStudentScores";
            Text = "Update Student Scores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName2;
        private Label lblName;
        private Label lblScores2;
        private Button btnAdd1;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnClearScores;
        private Button btnCancel2;
        private Button btnOk2;
        private ListBox lstScores;
    }
}