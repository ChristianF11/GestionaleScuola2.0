using System.Windows.Forms;

namespace Lab_1__Form_Application_
{
    partial class FrmList
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
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnListBack = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblListTitle
            // 
            this.lblListTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Impact", 28.2F);
            this.lblListTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListTitle.Location = new System.Drawing.Point(286, 9);
            this.lblListTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(441, 46);
            this.lblListTitle.TabIndex = 1;
            this.lblListTitle.Text = "ELENCO DOCENTI E STUDENTI";
            this.lblListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteMember.Font = new System.Drawing.Font("Dubai", 12F);
            this.btnDeleteMember.Location = new System.Drawing.Point(644, 458);
            this.btnDeleteMember.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(170, 60);
            this.btnDeleteMember.TabIndex = 1;
            this.btnDeleteMember.Text = "Elimina";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnListBack
            // 
            this.btnListBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnListBack.Font = new System.Drawing.Font("Dubai", 12F);
            this.btnListBack.Location = new System.Drawing.Point(11, 458);
            this.btnListBack.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnListBack.Name = "btnListBack";
            this.btnListBack.Size = new System.Drawing.Size(170, 60);
            this.btnListBack.TabIndex = 0;
            this.btnListBack.Text = "Indietro";
            this.btnListBack.UseVisualStyleBackColor = true;
            this.btnListBack.Click += new System.EventHandler(this.btnListBack_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDetails.Font = new System.Drawing.Font("Dubai", 12F);
            this.btnDetails.Location = new System.Drawing.Point(460, 458);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(170, 60);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "Dettagli";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteAll.Font = new System.Drawing.Font("Dubai", 12F);
            this.btnDeleteAll.Location = new System.Drawing.Point(828, 458);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(170, 60);
            this.btnDeleteAll.TabIndex = 4;
            this.btnDeleteAll.Text = "Elimina tutto";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1009, 528);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnListBack);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.lblListTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximumSize = new System.Drawing.Size(1025, 567);
            this.MinimumSize = new System.Drawing.Size(1025, 567);
            this.Name = "FrmList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionale C School";
            this.Load += new System.EventHandler(this.frmList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblListTitle;
        private Button btnDeleteMember;
        private Button btnListBack;
        private Button btnDetails;
        private Button btnDeleteAll;
    }
}