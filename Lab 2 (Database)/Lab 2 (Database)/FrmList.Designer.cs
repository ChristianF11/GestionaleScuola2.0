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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmList));
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnListBack = new System.Windows.Forms.Button();
            this.listViewSchool = new System.Windows.Forms.ListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnFirstName = new System.Windows.Forms.ColumnHeader();
            this.columnSecondName = new System.Windows.Forms.ColumnHeader();
            this.columnAge = new System.Windows.Forms.ColumnHeader();
            this.columnMail = new System.Windows.Forms.ColumnHeader();
            this.columnRole = new System.Windows.Forms.ColumnHeader();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblListTitle
            // 
            this.lblListTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListTitle.Location = new System.Drawing.Point(203, 9);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(540, 59);
            this.lblListTitle.TabIndex = 1;
            this.lblListTitle.Text = "ELENCO DOCENTI E STUDENTI";
            this.lblListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteMember.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteMember.Location = new System.Drawing.Point(472, 494);
            this.btnDeleteMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(208, 71);
            this.btnDeleteMember.TabIndex = 1;
            this.btnDeleteMember.Text = "Elimina";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnListBack
            // 
            this.btnListBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnListBack.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListBack.Location = new System.Drawing.Point(12, 493);
            this.btnListBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListBack.Name = "btnListBack";
            this.btnListBack.Size = new System.Drawing.Size(208, 71);
            this.btnListBack.TabIndex = 0;
            this.btnListBack.Text = "Indietro";
            this.btnListBack.UseVisualStyleBackColor = true;
            this.btnListBack.Click += new System.EventHandler(this.btnListBack_Click);
            // 
            // listViewSchool
            // 
            this.listViewSchool.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listViewSchool.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnFirstName,
            this.columnSecondName,
            this.columnAge,
            this.columnMail,
            this.columnRole});
            this.listViewSchool.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewSchool.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.listViewSchool.FullRowSelect = true;
            this.listViewSchool.GridLines = true;
            this.listViewSchool.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSchool.Location = new System.Drawing.Point(54, 76);
            this.listViewSchool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewSchool.MaximumSize = new System.Drawing.Size(813, 385);
            this.listViewSchool.MinimumSize = new System.Drawing.Size(813, 385);
            this.listViewSchool.Name = "listViewSchool";
            this.listViewSchool.Size = new System.Drawing.Size(813, 385);
            this.listViewSchool.TabIndex = 2;
            this.listViewSchool.UseCompatibleStateImageBehavior = false;
            this.listViewSchool.View = System.Windows.Forms.View.Details;
            this.listViewSchool.SelectedIndexChanged += new System.EventHandler(this.listSchool_SelectedIndexChanged_1);
            // 
            // columnID
            // 
            this.columnID.Text = "Cod";
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "Nome";
            this.columnFirstName.Width = 160;
            // 
            // columnSecondName
            // 
            this.columnSecondName.Text = "Cognome";
            this.columnSecondName.Width = 160;
            // 
            // columnAge
            // 
            this.columnAge.Text = "Età";
            this.columnAge.Width = 80;
            // 
            // columnMail
            // 
            this.columnMail.Text = "E-mail";
            this.columnMail.Width = 178;
            // 
            // columnRole
            // 
            this.columnRole.Text = "Ruolo";
            this.columnRole.Width = 170;
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDetails.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDetails.Location = new System.Drawing.Point(241, 493);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(208, 71);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "Dettagli";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteAll.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteAll.Location = new System.Drawing.Point(703, 493);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(208, 71);
            this.btnDeleteAll.TabIndex = 4;
            this.btnDeleteAll.Text = "Elimina tutto";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(923, 576);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.listViewSchool);
            this.Controls.Add(this.btnListBack);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.lblListTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(941, 623);
            this.MinimumSize = new System.Drawing.Size(941, 623);
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
        private ListView listViewSchool;
        private ColumnHeader columnFirstName;
        private ColumnHeader columnSecondName;
        private ColumnHeader columnAge;
        private ColumnHeader columnMail;
        private ColumnHeader columnRole;
        private ColumnHeader columnID;
        private Button btnDetails;
        private Button btnDeleteAll;
    }
}