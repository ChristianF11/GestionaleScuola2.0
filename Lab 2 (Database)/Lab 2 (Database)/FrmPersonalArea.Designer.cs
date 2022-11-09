using System.Windows.Forms;

namespace Lab_1__Form_Application_
{
    partial class FrmPersonalArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonalArea));
            this.lblAreaPersonale = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtGpa = new System.Windows.Forms.TextBox();
            this.lblGpa = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAreaPersonale
            // 
            this.lblAreaPersonale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAreaPersonale.AutoSize = true;
            this.lblAreaPersonale.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAreaPersonale.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAreaPersonale.Location = new System.Drawing.Point(370, 9);
            this.lblAreaPersonale.Name = "lblAreaPersonale";
            this.lblAreaPersonale.Size = new System.Drawing.Size(282, 48);
            this.lblAreaPersonale.TabIndex = 4;
            this.lblAreaPersonale.Text = "AREA PERSONALE";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 476);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 51);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Indietro";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstName.Location = new System.Drawing.Point(39, 75);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(95, 51);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "Nome";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(49, 129);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(155, 36);
            this.txtFirstName.TabIndex = 7;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtSecondName
            // 
            this.txtSecondName.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSecondName.Location = new System.Drawing.Point(49, 268);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.ReadOnly = true;
            this.txtSecondName.Size = new System.Drawing.Size(155, 36);
            this.txtSecondName.TabIndex = 9;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecondName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSecondName.Location = new System.Drawing.Point(39, 214);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(136, 51);
            this.lblSecondName.TabIndex = 8;
            this.lblSecondName.Text = "Cognome";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(266, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(203, 36);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(256, 75);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(89, 51);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(266, 268);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(177, 36);
            this.txtPassword.TabIndex = 13;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassword.Location = new System.Drawing.Point(256, 214);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(140, 51);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAge.Location = new System.Drawing.Point(501, 129);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(141, 36);
            this.txtAge.TabIndex = 15;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAge.Location = new System.Drawing.Point(491, 75);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(63, 51);
            this.lblAge.TabIndex = 14;
            this.lblAge.Text = "Età";
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRole.Location = new System.Drawing.Point(501, 268);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(141, 36);
            this.txtRole.TabIndex = 17;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRole.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRole.Location = new System.Drawing.Point(491, 214);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(91, 51);
            this.lblRole.TabIndex = 16;
            this.lblRole.Text = "Ruolo";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalary.Location = new System.Drawing.Point(688, 129);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(177, 36);
            this.txtSalary.TabIndex = 19;
            this.txtSalary.Visible = false;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSalary.Location = new System.Drawing.Point(678, 75);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(137, 51);
            this.lblSalary.TabIndex = 18;
            this.lblSalary.Text = "Stipendio";
            this.lblSalary.Visible = false;
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubject.Location = new System.Drawing.Point(688, 268);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(177, 36);
            this.txtSubject.TabIndex = 21;
            this.txtSubject.Visible = false;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSubject.Location = new System.Drawing.Point(678, 214);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(118, 51);
            this.lblSubject.TabIndex = 20;
            this.lblSubject.Text = "Materia";
            this.lblSubject.Visible = false;
            // 
            // txtGpa
            // 
            this.txtGpa.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGpa.Location = new System.Drawing.Point(688, 129);
            this.txtGpa.Name = "txtGpa";
            this.txtGpa.ReadOnly = true;
            this.txtGpa.Size = new System.Drawing.Size(177, 36);
            this.txtGpa.TabIndex = 23;
            this.txtGpa.Visible = false;
            // 
            // lblGpa
            // 
            this.lblGpa.AutoSize = true;
            this.lblGpa.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGpa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGpa.Location = new System.Drawing.Point(678, 75);
            this.lblGpa.Name = "lblGpa";
            this.lblGpa.Size = new System.Drawing.Size(77, 51);
            this.lblGpa.TabIndex = 22;
            this.lblGpa.Text = "GPA";
            this.lblGpa.Visible = false;
            // 
            // txtCourse
            // 
            this.txtCourse.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCourse.Location = new System.Drawing.Point(688, 268);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.ReadOnly = true;
            this.txtCourse.Size = new System.Drawing.Size(177, 36);
            this.txtCourse.TabIndex = 25;
            this.txtCourse.Visible = false;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCourse.Location = new System.Drawing.Point(678, 214);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(93, 51);
            this.lblCourse.TabIndex = 24;
            this.lblCourse.Text = "Corso";
            this.lblCourse.Visible = false;
            // 
            // FrmPersonalArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1011, 539);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtGpa);
            this.Controls.Add(this.lblGpa);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAreaPersonale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1029, 586);
            this.MinimumSize = new System.Drawing.Size(1029, 586);
            this.Name = "FrmPersonalArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionale C School";
            this.Load += new System.EventHandler(this.FrmPersonalArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAreaPersonale;
        private Button btnBack;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private Label lblSecondName;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtAge;
        private Label lblAge;
        private TextBox txtRole;
        private Label lblRole;
        private TextBox txtSalary;
        private Label lblSalary;
        private TextBox txtSubject;
        private Label lblSubject;
        private TextBox txtGpa;
        private Label lblGpa;
        private TextBox txtCourse;
        private Label lblCourse;
    }
}