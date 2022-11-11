namespace Lab_2__Database_
{
    partial class FrmTeachersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeachersList));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeletAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridTeacher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(496, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 53);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "ELENCO DOCENTI";
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(675, 532);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(198, 74);
            this.btnDetails.TabIndex = 9;
            this.btnDetails.Text = "Dettagli";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(895, 532);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(198, 74);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Elimina";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeletAll
            // 
            this.btnDeletAll.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletAll.Location = new System.Drawing.Point(1114, 532);
            this.btnDeletAll.Name = "btnDeletAll";
            this.btnDeletAll.Size = new System.Drawing.Size(198, 74);
            this.btnDeletAll.TabIndex = 7;
            this.btnDeletAll.Text = "Elimina tutto";
            this.btnDeletAll.UseVisualStyleBackColor = true;
            this.btnDeletAll.Click += new System.EventHandler(this.btnDeletAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(26, 532);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(198, 74);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Indietro";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridTeacher
            // 
            this.dataGridTeacher.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridTeacher.ColumnHeadersHeight = 50;
            this.dataGridTeacher.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridTeacher.Location = new System.Drawing.Point(26, 77);
            this.dataGridTeacher.MaximumSize = new System.Drawing.Size(1266, 429);
            this.dataGridTeacher.MinimumSize = new System.Drawing.Size(1266, 429);
            this.dataGridTeacher.Name = "dataGridTeacher";
            this.dataGridTeacher.ReadOnly = true;
            this.dataGridTeacher.RowHeadersWidth = 148;
            this.dataGridTeacher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridTeacher.RowTemplate.Height = 24;
            this.dataGridTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTeacher.Size = new System.Drawing.Size(1266, 429);
            this.dataGridTeacher.TabIndex = 11;
            // 
            // FrmTeachersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1328, 618);
            this.Controls.Add(this.dataGridTeacher);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDeletAll);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTeachersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionale C School";
            this.Load += new System.EventHandler(this.FrmTeachersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeletAll;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridTeacher;
    }
}