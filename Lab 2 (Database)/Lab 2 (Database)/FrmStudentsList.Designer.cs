namespace Lab_2__Database_
{
    partial class FrmStudentsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentsList));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeletAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.listStudents = new System.Windows.Forms.ListView();
            this.columnFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSecondName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 532);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(198, 74);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Indietro";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeletAll
            // 
            this.btnDeletAll.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletAll.Location = new System.Drawing.Point(1118, 532);
            this.btnDeletAll.Name = "btnDeletAll";
            this.btnDeletAll.Size = new System.Drawing.Size(198, 74);
            this.btnDeletAll.TabIndex = 1;
            this.btnDeletAll.Text = "Elimina tutto";
            this.btnDeletAll.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(899, 532);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(198, 74);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Elimina";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(679, 532);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(198, 74);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "Dettagli";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(496, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(321, 54);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "ELENCO STUDENTI";
            // 
            // listStudents
            // 
            this.listStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listStudents.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFirstName,
            this.columnSecondName,
            this.columnAge,
            this.columnEmail});
            this.listStudents.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listStudents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.listStudents.FullRowSelect = true;
            this.listStudents.GridLines = true;
            this.listStudents.HideSelection = false;
            this.listStudents.Location = new System.Drawing.Point(22, 66);
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(1294, 426);
            this.listStudents.TabIndex = 5;
            this.listStudents.UseCompatibleStateImageBehavior = false;
            this.listStudents.View = System.Windows.Forms.View.Details;
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "Nome";
            this.columnFirstName.Width = 253;
            // 
            // columnSecondName
            // 
            this.columnSecondName.Text = "Cognome";
            this.columnSecondName.Width = 182;
            // 
            // columnAge
            // 
            this.columnAge.Text = "Età";
            this.columnAge.Width = 237;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 520;
            // 
            // FrmStudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1328, 618);
            this.Controls.Add(this.listStudents);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDeletAll);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1346, 665);
            this.MinimumSize = new System.Drawing.Size(1346, 665);
            this.Name = "FrmStudentsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionale C School";
            this.Load += new System.EventHandler(this.FrmStudentsList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeletAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView listStudents;
        private System.Windows.Forms.ColumnHeader columnFirstName;
        private System.Windows.Forms.ColumnHeader columnSecondName;
        private System.Windows.Forms.ColumnHeader columnAge;
        private System.Windows.Forms.ColumnHeader columnEmail;
    }
}