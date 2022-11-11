using System.Windows.Forms;

namespace Lab_2__Database_
{
    partial class FrmPersonalPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonalPage));
            this.lblAreaPersonale = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridPersonal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAreaPersonale
            // 
            this.lblAreaPersonale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAreaPersonale.AutoSize = true;
            this.lblAreaPersonale.Font = new System.Drawing.Font("Impact", 24F);
            this.lblAreaPersonale.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAreaPersonale.Location = new System.Drawing.Point(399, 7);
            this.lblAreaPersonale.Name = "lblAreaPersonale";
            this.lblAreaPersonale.Size = new System.Drawing.Size(282, 48);
            this.lblAreaPersonale.TabIndex = 4;
            this.lblAreaPersonale.Text = "AREA PERSONALE";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Dubai", 12F);
            this.btnBack.Location = new System.Drawing.Point(12, 447);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 74);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Indietro";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Font = new System.Drawing.Font("Dubai", 12F);
            this.btnEdit.Location = new System.Drawing.Point(766, 443);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(288, 74);
            this.btnEdit.TabIndex = 46;
            this.btnEdit.Text = "Salva Modifiche";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridPersonal
            // 
            this.dataGridPersonal.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonal.Location = new System.Drawing.Point(26, 55);
            this.dataGridPersonal.Name = "dataGridPersonal";
            this.dataGridPersonal.RowHeadersWidth = 51;
            this.dataGridPersonal.RowTemplate.Height = 24;
            this.dataGridPersonal.Size = new System.Drawing.Size(1007, 365);
            this.dataGridPersonal.TabIndex = 49;
            // 
            // FrmPersonalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1066, 528);
            this.Controls.Add(this.dataGridPersonal);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAreaPersonale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1084, 575);
            this.MinimumSize = new System.Drawing.Size(1084, 575);
            this.Name = "FrmPersonalPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionale C School";
            this.Load += new System.EventHandler(this.FrmPersonalArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAreaPersonale;
        private Button btnBack;
        private Button btnEdit;
        private DataGridView dataGridPersonal;
    }
}