using System.Windows.Forms;

namespace Lab_1__Form_Application_
{
    partial class FrmAddMenu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSelectRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.txtGpa = new System.Windows.Forms.TextBox();
            this.lblGpa = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 25.8F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(335, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 53);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "INSERISCI I DATI";
            // 
            // lblSelectRole
            // 
            this.lblSelectRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSelectRole.AutoSize = true;
            this.lblSelectRole.Font = new System.Drawing.Font("Dubai", 12F);
            this.lblSelectRole.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSelectRole.Location = new System.Drawing.Point(33, 70);
            this.lblSelectRole.Name = "lblSelectRole";
            this.lblSelectRole.Size = new System.Drawing.Size(153, 34);
            this.lblSelectRole.TabIndex = 1;
            this.lblSelectRole.Text = "Seleziona il ruolo";
            // 
            // cmbRole
            // 
            this.cmbRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbRole.Font = new System.Drawing.Font("Dubai", 9F);
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Docente",
            "Studente"});
            this.cmbRole.Location = new System.Drawing.Point(33, 99);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(184, 33);
            this.cmbRole.TabIndex = 0;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Dubai", 12F);
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstName.Location = new System.Drawing.Point(301, 70);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 34);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "Nome*";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtFirstName.Location = new System.Drawing.Point(301, 100);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(195, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSecondName.Location = new System.Drawing.Point(517, 100);
            this.txtSecondName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSecondName.MaxLength = 25;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(195, 22);
            this.txtSecondName.TabIndex = 2;
            // 
            // lblSecondName
            // 
            this.lblSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Dubai", 12F);
            this.lblSecondName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSecondName.Location = new System.Drawing.Point(516, 70);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(100, 34);
            this.lblSecondName.TabIndex = 4;
            this.lblSecondName.Text = "Cognome*";
            // 
            // txtAge
            // 
            this.txtAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAge.Location = new System.Drawing.Point(738, 100);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAge.MaxLength = 25;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(150, 22);
            this.txtAge.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Dubai", 12F);
            this.lblAge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAge.Location = new System.Drawing.Point(738, 70);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(52, 34);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Età*";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmail.Location = new System.Drawing.Point(301, 178);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Dubai", 12F);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(301, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 34);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail*";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPassword.Location = new System.Drawing.Point(517, 178);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.MaxLength = 25;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(195, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Dubai", 12F);
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassword.Location = new System.Drawing.Point(517, 148);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 34);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password*";
            // 
            // txtCourse
            // 
            this.txtCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCourse.Location = new System.Drawing.Point(516, 261);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCourse.MaxLength = 25;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(183, 22);
            this.txtCourse.TabIndex = 7;
            this.txtCourse.Visible = false;
            // 
            // lblCourse
            // 
            this.lblCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Dubai", 12F);
            this.lblCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCourse.Location = new System.Drawing.Point(516, 231);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(61, 34);
            this.lblCourse.TabIndex = 6;
            this.lblCourse.Text = "Corso";
            this.lblCourse.Visible = false;
            // 
            // txtGpa
            // 
            this.txtGpa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtGpa.Location = new System.Drawing.Point(301, 261);
            this.txtGpa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGpa.MaxLength = 25;
            this.txtGpa.Name = "txtGpa";
            this.txtGpa.Size = new System.Drawing.Size(150, 22);
            this.txtGpa.TabIndex = 6;
            this.txtGpa.Visible = false;
            // 
            // lblGpa
            // 
            this.lblGpa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblGpa.AutoSize = true;
            this.lblGpa.Font = new System.Drawing.Font("Dubai", 12F);
            this.lblGpa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGpa.Location = new System.Drawing.Point(301, 231);
            this.lblGpa.Name = "lblGpa";
            this.lblGpa.Size = new System.Drawing.Size(52, 34);
            this.lblGpa.TabIndex = 8;
            this.lblGpa.Text = "GPA";
            this.lblGpa.Visible = false;
            // 
            // lblStudent
            // 
            this.lblStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Impact", 16.2F);
            this.lblStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStudent.Location = new System.Drawing.Point(114, 261);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(124, 35);
            this.lblStudent.TabIndex = 10;
            this.lblStudent.Text = "STUDENTE";
            this.lblStudent.Visible = false;
            // 
            // lblTeacher
            // 
            this.lblTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Impact", 16.2F);
            this.lblTeacher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTeacher.Location = new System.Drawing.Point(114, 338);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(113, 35);
            this.lblTeacher.TabIndex = 15;
            this.lblTeacher.Text = "DOCENTE";
            this.lblTeacher.Visible = false;
            // 
            // txtSalary
            // 
            this.txtSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSalary.Location = new System.Drawing.Point(301, 345);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.MaxLength = 25;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(150, 22);
            this.txtSalary.TabIndex = 6;
            this.txtSalary.Visible = false;
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Dubai", 12F);
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSalary.Location = new System.Drawing.Point(301, 315);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(92, 34);
            this.lblSalary.TabIndex = 13;
            this.lblSalary.Text = "Stipendio";
            this.lblSalary.Visible = false;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSubject.Location = new System.Drawing.Point(516, 346);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubject.MaxLength = 25;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(183, 22);
            this.txtSubject.TabIndex = 7;
            this.txtSubject.Visible = false;
            // 
            // lblSubject
            // 
            this.lblSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Dubai", 12F);
            this.lblSubject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSubject.Location = new System.Drawing.Point(516, 316);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(77, 34);
            this.lblSubject.TabIndex = 11;
            this.lblSubject.Text = "Materia";
            this.lblSubject.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Dubai", 12F);
            this.btnAdd.Location = new System.Drawing.Point(809, 282);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Aggiungi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Dubai", 12F);
            this.btnClear.Location = new System.Drawing.Point(809, 338);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 42);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Cancella";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Dubai", 12F);
            this.btnBack.Location = new System.Drawing.Point(809, 393);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 42);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Indietro";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Dubai", 9F);
            this.lblInformation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInformation.Location = new System.Drawing.Point(12, 415);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(127, 25);
            this.lblInformation.TabIndex = 19;
            this.lblInformation.Text = "*Campi obbligatori";
            // 
            // FrmAddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(961, 445);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.txtGpa);
            this.Controls.Add(this.lblGpa);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblSelectRole);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(979, 492);
            this.MinimumSize = new System.Drawing.Size(979, 492);
            this.Name = "FrmAddMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionale C School";
            this.Load += new System.EventHandler(this.frmAddMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblSelectRole;
        private ComboBox cmbRole;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private Label lblSecondName;
        private TextBox txtAge;
        private Label lblAge;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtCourse;
        private Label lblCourse;
        private TextBox txtGpa;
        private Label lblGpa;
        private Label lblStudent;
        private Label lblTeacher;
        private TextBox txtSalary;
        private Label lblSalary;
        private TextBox txtSubject;
        private Label lblSubject;
        private Button btnAdd;
        private Button btnClear;
        private Button btnBack;
        private Label lblInformation;
    }
}