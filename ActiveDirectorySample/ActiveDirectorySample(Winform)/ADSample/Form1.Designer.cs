namespace ADSample
{
    partial class Form1
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
            this.ADGroupsComboBox = new System.Windows.Forms.ComboBox();
            this.ADUsersComboBox = new System.Windows.Forms.ComboBox();
            this.UsersInGroupButton = new System.Windows.Forms.Button();
            this.SelectedUserGroupsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectedGroupUsersComboBox = new System.Windows.Forms.ComboBox();
            this.GetUsersGroupsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADGroupsComboBox
            // 
            this.ADGroupsComboBox.FormattingEnabled = true;
            this.ADGroupsComboBox.Location = new System.Drawing.Point(261, 6);
            this.ADGroupsComboBox.Name = "ADGroupsComboBox";
            this.ADGroupsComboBox.Size = new System.Drawing.Size(121, 21);
            this.ADGroupsComboBox.TabIndex = 0;
            // 
            // ADUsersComboBox
            // 
            this.ADUsersComboBox.FormattingEnabled = true;
            this.ADUsersComboBox.Location = new System.Drawing.Point(261, 36);
            this.ADUsersComboBox.Name = "ADUsersComboBox";
            this.ADUsersComboBox.Size = new System.Drawing.Size(121, 21);
            this.ADUsersComboBox.TabIndex = 1;
            // 
            // UsersInGroupButton
            // 
            this.UsersInGroupButton.Location = new System.Drawing.Point(12, 91);
            this.UsersInGroupButton.Name = "UsersInGroupButton";
            this.UsersInGroupButton.Size = new System.Drawing.Size(172, 23);
            this.UsersInGroupButton.TabIndex = 2;
            this.UsersInGroupButton.Text = "Seçili Gruptaki Kullanıcıları getir";
            this.UsersInGroupButton.UseVisualStyleBackColor = true;
            this.UsersInGroupButton.Click += new System.EventHandler(this.UsersInGroupButton_Click);
            // 
            // SelectedUserGroupsComboBox
            // 
            this.SelectedUserGroupsComboBox.FormattingEnabled = true;
            this.SelectedUserGroupsComboBox.Location = new System.Drawing.Point(190, 122);
            this.SelectedUserGroupsComboBox.Name = "SelectedUserGroupsComboBox";
            this.SelectedUserGroupsComboBox.Size = new System.Drawing.Size(203, 21);
            this.SelectedUserGroupsComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Active Directory (Lokalde ayarlıdır şuan) gruplar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Active Directory (Lokalde ayarlıdır şuan) kullanıcılar :";
            // 
            // SelectedGroupUsersComboBox
            // 
            this.SelectedGroupUsersComboBox.FormattingEnabled = true;
            this.SelectedGroupUsersComboBox.Location = new System.Drawing.Point(190, 93);
            this.SelectedGroupUsersComboBox.Name = "SelectedGroupUsersComboBox";
            this.SelectedGroupUsersComboBox.Size = new System.Drawing.Size(203, 21);
            this.SelectedGroupUsersComboBox.TabIndex = 10;
            // 
            // GetUsersGroupsButton
            // 
            this.GetUsersGroupsButton.Location = new System.Drawing.Point(12, 120);
            this.GetUsersGroupsButton.Name = "GetUsersGroupsButton";
            this.GetUsersGroupsButton.Size = new System.Drawing.Size(172, 23);
            this.GetUsersGroupsButton.TabIndex = 11;
            this.GetUsersGroupsButton.Text = "Seçili Kullanıcının Gruplarını getir";
            this.GetUsersGroupsButton.UseVisualStyleBackColor = true;
            this.GetUsersGroupsButton.Click += new System.EventHandler(this.GetUsersGroupsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 159);
            this.Controls.Add(this.GetUsersGroupsButton);
            this.Controls.Add(this.SelectedGroupUsersComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectedUserGroupsComboBox);
            this.Controls.Add(this.UsersInGroupButton);
            this.Controls.Add(this.ADUsersComboBox);
            this.Controls.Add(this.ADGroupsComboBox);
            this.Name = "Form1";
            this.Text = "Using Active Directory Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ADGroupsComboBox;
        private System.Windows.Forms.ComboBox ADUsersComboBox;
        private System.Windows.Forms.Button UsersInGroupButton;
        private System.Windows.Forms.ComboBox SelectedUserGroupsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SelectedGroupUsersComboBox;
        private System.Windows.Forms.Button GetUsersGroupsButton;

    }
}

