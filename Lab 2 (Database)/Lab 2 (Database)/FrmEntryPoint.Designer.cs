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
            this.btnViewList = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnDefaultInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(218, 9);
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
            this.btnAddStudent.Location = new System.Drawing.Point(193, 102);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(314, 63);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "AGGIUNGI NUOVO MEMBRO";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnViewList
            // 
            this.btnViewList.Location = new System.Drawing.Point(193, 181);
            this.btnViewList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(314, 63);
            this.btnViewList.TabIndex = 2;
            this.btnViewList.Text = "VISUALIZZA LISTA";
            this.btnViewList.UseVisualStyleBackColor = true;
            this.btnViewList.Click += new System.EventHandler(this.btnViewList_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(193, 263);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(314, 63);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnDefaultInput
            // 
            this.btnDefaultInput.Location = new System.Drawing.Point(193, 345);
            this.btnDefaultInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDefaultInput.Name = "btnDefaultInput";
            this.btnDefaultInput.Size = new System.Drawing.Size(314, 63);
            this.btnDefaultInput.TabIndex = 4;
            this.btnDefaultInput.Text = "DEFAULT INPUT";
            this.btnDefaultInput.UseVisualStyleBackColor = true;
            this.btnDefaultInput.Click += new System.EventHandler(this.btnDefaultInput_Click);
            // 
            // FrmEntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(682, 448);
            this.Controls.Add(this.btnDefaultInput);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnViewList);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(700, 495);
            this.MinimumSize = new System.Drawing.Size(700, 495);
            this.Name = "FrmEntryPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionale C School";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnAddStudent;
        private Button btnViewList;
        private Button btnLogin;
        private Button btnDefaultInput;
    }
}