namespace StudentInformation
{
    partial class Form1
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
            this.LblstudentId = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.LblSemester = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtStudentId = new System.Windows.Forms.TextBox();
            this.TxtSemester = new System.Windows.Forms.TextBox();
            this.TxtDepartment = new System.Windows.Forms.TextBox();
            this.LplOutput = new System.Windows.Forms.Label();
            this.ShowInformationBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblstudentId
            // 
            this.LblstudentId.AutoSize = true;
            this.LblstudentId.Location = new System.Drawing.Point(167, 119);
            this.LblstudentId.Name = "LblstudentId";
            this.LblstudentId.Size = new System.Drawing.Size(139, 17);
            this.LblstudentId.TabIndex = 0;
            this.LblstudentId.Text = "Enter the student ID:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(144, 86);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(162, 17);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Enter the Student Name:";
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Location = new System.Drawing.Point(158, 158);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(148, 17);
            this.LblDepartment.TabIndex = 0;
            this.LblDepartment.Text = "Enter the Department:";
            // 
            // LblSemester
            // 
            this.LblSemester.AutoSize = true;
            this.LblSemester.Location = new System.Drawing.Point(167, 195);
            this.LblSemester.Name = "LblSemester";
            this.LblSemester.Size = new System.Drawing.Size(131, 17);
            this.LblSemester.TabIndex = 0;
            this.LblSemester.Text = "Enter the Semester:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(344, 79);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(166, 24);
            this.TxtName.TabIndex = 1;
            // 
            // TxtStudentId
            // 
            this.TxtStudentId.Location = new System.Drawing.Point(344, 112);
            this.TxtStudentId.Name = "TxtStudentId";
            this.TxtStudentId.Size = new System.Drawing.Size(166, 24);
            this.TxtStudentId.TabIndex = 1;
            // 
            // TxtSemester
            // 
            this.TxtSemester.Location = new System.Drawing.Point(344, 188);
            this.TxtSemester.Name = "TxtSemester";
            this.TxtSemester.Size = new System.Drawing.Size(166, 24);
            this.TxtSemester.TabIndex = 1;
            // 
            // TxtDepartment
            // 
            this.TxtDepartment.Location = new System.Drawing.Point(344, 151);
            this.TxtDepartment.Name = "TxtDepartment";
            this.TxtDepartment.Size = new System.Drawing.Size(166, 24);
            this.TxtDepartment.TabIndex = 1;
            // 
            // LplOutput
            // 
            this.LplOutput.AutoEllipsis = true;
            this.LplOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LplOutput.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LplOutput.Location = new System.Drawing.Point(124, 260);
            this.LplOutput.Name = "LplOutput";
            this.LplOutput.Size = new System.Drawing.Size(403, 48);
            this.LplOutput.TabIndex = 2;
            // 
            // ShowInformationBtn
            // 
            this.ShowInformationBtn.Location = new System.Drawing.Point(124, 327);
            this.ShowInformationBtn.Name = "ShowInformationBtn";
            this.ShowInformationBtn.Size = new System.Drawing.Size(163, 29);
            this.ShowInformationBtn.TabIndex = 3;
            this.ShowInformationBtn.Text = "Show Information";
            this.ShowInformationBtn.UseVisualStyleBackColor = true;
            this.ShowInformationBtn.Click += new System.EventHandler(this.ShowInformationBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(293, 327);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(114, 29);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(413, 327);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(114, 29);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(141, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "STUDENT INFORMATION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ShowInformationBtn);
            this.Controls.Add(this.LplOutput);
            this.Controls.Add(this.TxtDepartment);
            this.Controls.Add(this.TxtSemester);
            this.Controls.Add(this.TxtStudentId);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblSemester);
            this.Controls.Add(this.LblDepartment);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblstudentId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblstudentId;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.Label LblSemester;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtStudentId;
        private System.Windows.Forms.TextBox TxtSemester;
        private System.Windows.Forms.TextBox TxtDepartment;
        private System.Windows.Forms.Label LplOutput;
        private System.Windows.Forms.Button ShowInformationBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
    }
}

