using System.Windows.Forms;

namespace Lab_2__Database_
{
    partial class FrmEntryPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntryPoint));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnToStudentList = new System.Windows.Forms.Button();
            this.btnToTeacherList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 36F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(279, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 75);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "C SCHOOL";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStudent.Location = new System.Drawing.Point(253, 126);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(314, 88);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "AGGIUNGI NUOVO MEMBRO";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnToStudentList
            // 
            this.btnToStudentList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToStudentList.Location = new System.Drawing.Point(253, 254);
            this.btnToStudentList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnToStudentList.Name = "btnToStudentList";
            this.btnToStudentList.Size = new System.Drawing.Size(314, 88);
            this.btnToStudentList.TabIndex = 2;
            this.btnToStudentList.Text = "VISUALIZZA LISTA STUDENTI";
            this.btnToStudentList.UseVisualStyleBackColor = true;
            this.btnToStudentList.Click += new System.EventHandler(this.btnViewList_Click);
            // 
            // btnToTeacherList
            // 
            this.btnToTeacherList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToTeacherList.Location = new System.Drawing.Point(253, 388);
            this.btnToTeacherList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnToTeacherList.Name = "btnToTeacherList";
            this.btnToTeacherList.Size = new System.Drawing.Size(314, 88);
            this.btnToTeacherList.TabIndex = 4;
            this.btnToTeacherList.Text = "VISUALIZZA LISTA DOCENTI";
            this.btnToTeacherList.UseVisualStyleBackColor = true;
            this.btnToTeacherList.Click += new System.EventHandler(this.btnToTeacherList_Click);
            // 
            // FrmEntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(789, 562);
            this.Controls.Add(this.btnToTeacherList);
            this.Controls.Add(this.btnToStudentList);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmEntryPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionale C School";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnAddStudent;
        private Button btnToStudentList;
        private Button btnToTeacherList;
    }
}