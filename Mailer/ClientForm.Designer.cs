﻿namespace Mailer
{
    partial class ClientForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.dataGridViewEmailList = new System.Windows.Forms.DataGridView();
            this.SenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webBrowserMailView = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmailList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "buttonBack";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelUsername.Location = new System.Drawing.Point(129, 12);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 20);
            this.labelUsername.TabIndex = 3;
            // 
            // dataGridViewEmailList
            // 
            this.dataGridViewEmailList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SenderName,
            this.SenderAddress,
            this.Subject});
            this.dataGridViewEmailList.Location = new System.Drawing.Point(196, 97);
            this.dataGridViewEmailList.Name = "dataGridViewEmailList";
            this.dataGridViewEmailList.ReadOnly = true;
            this.dataGridViewEmailList.Size = new System.Drawing.Size(930, 151);
            this.dataGridViewEmailList.TabIndex = 4;
            this.dataGridViewEmailList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmailList_CellClick);
            this.dataGridViewEmailList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmailList_CellContentClick);
            // 
            // SenderName
            // 
            this.SenderName.HeaderText = "Sender Name";
            this.SenderName.Name = "SenderName";
            this.SenderName.ReadOnly = true;
            // 
            // SenderAddress
            // 
            this.SenderAddress.HeaderText = "Sender Address";
            this.SenderAddress.Name = "SenderAddress";
            this.SenderAddress.ReadOnly = true;
            this.SenderAddress.Width = 200;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 500;
            // 
            // webBrowserMailView
            // 
            this.webBrowserMailView.AllowNavigation = false;
            this.webBrowserMailView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserMailView.Location = new System.Drawing.Point(196, 265);
            this.webBrowserMailView.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMailView.Name = "webBrowserMailView";
            this.webBrowserMailView.Size = new System.Drawing.Size(930, 415);
            this.webBrowserMailView.TabIndex = 5;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 692);
            this.Controls.Add(this.webBrowserMailView);
            this.Controls.Add(this.dataGridViewEmailList);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonBack);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmailList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.DataGridView dataGridViewEmailList;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.WebBrowser webBrowserMailView;
    }
}