namespace XMLLessons
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.XMLDataGridView = new System.Windows.Forms.DataGridView();
			this.ReadDataButton = new System.Windows.Forms.Button();
			this.SearchXMLDataButton = new System.Windows.Forms.Button();
			this.SearchXMLDataButton2 = new System.Windows.Forms.Button();
			this.UpdateXMLDataButton = new System.Windows.Forms.Button();
			this.SearchXMLDataButton3 = new System.Windows.Forms.Button();
			this.DeleteXMLDataButton = new System.Windows.Forms.Button();
			this.AddXMLDataButton = new System.Windows.Forms.Button();
			this.SQLToXMLButton = new System.Windows.Forms.Button();
			this.XMLToSQLButton = new System.Windows.Forms.Button();
			this.GenerateXMLSchemaButton = new System.Windows.Forms.Button();
			this.SQLToXMLWithSchemaButton = new System.Windows.Forms.Button();
			this.XMLSchemaValidationButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.XMLDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// XMLDataGridView
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.XMLDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.XMLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.XMLDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.XMLDataGridView.Location = new System.Drawing.Point(12, 12);
			this.XMLDataGridView.Name = "XMLDataGridView";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.XMLDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.XMLDataGridView.Size = new System.Drawing.Size(597, 268);
			this.XMLDataGridView.TabIndex = 0;
			// 
			// ReadDataButton
			// 
			this.ReadDataButton.Location = new System.Drawing.Point(12, 306);
			this.ReadDataButton.Name = "ReadDataButton";
			this.ReadDataButton.Size = new System.Drawing.Size(75, 23);
			this.ReadDataButton.TabIndex = 1;
			this.ReadDataButton.Text = "Veri Oku";
			this.ReadDataButton.UseVisualStyleBackColor = true;
			this.ReadDataButton.Click += new System.EventHandler(this.ReadDataButton_Click);
			// 
			// SearchXMLDataButton
			// 
			this.SearchXMLDataButton.Location = new System.Drawing.Point(93, 306);
			this.SearchXMLDataButton.Name = "SearchXMLDataButton";
			this.SearchXMLDataButton.Size = new System.Drawing.Size(75, 23);
			this.SearchXMLDataButton.TabIndex = 2;
			this.SearchXMLDataButton.Text = "Veri Bul";
			this.SearchXMLDataButton.UseVisualStyleBackColor = true;
			this.SearchXMLDataButton.Click += new System.EventHandler(this.SearchXMLDataButton_Click);
			// 
			// SearchXMLDataButton2
			// 
			this.SearchXMLDataButton2.Location = new System.Drawing.Point(93, 335);
			this.SearchXMLDataButton2.Name = "SearchXMLDataButton2";
			this.SearchXMLDataButton2.Size = new System.Drawing.Size(75, 23);
			this.SearchXMLDataButton2.TabIndex = 3;
			this.SearchXMLDataButton2.Text = "Veri Bul 2";
			this.SearchXMLDataButton2.UseVisualStyleBackColor = true;
			this.SearchXMLDataButton2.Click += new System.EventHandler(this.SearchXMLDataButton2_Click);
			// 
			// UpdateXMLDataButton
			// 
			this.UpdateXMLDataButton.Location = new System.Drawing.Point(174, 306);
			this.UpdateXMLDataButton.Name = "UpdateXMLDataButton";
			this.UpdateXMLDataButton.Size = new System.Drawing.Size(75, 23);
			this.UpdateXMLDataButton.TabIndex = 4;
			this.UpdateXMLDataButton.Text = "Veri Değiştir";
			this.UpdateXMLDataButton.UseVisualStyleBackColor = true;
			this.UpdateXMLDataButton.Click += new System.EventHandler(this.UpdateXMLDataButton_Click);
			// 
			// SearchXMLDataButton3
			// 
			this.SearchXMLDataButton3.Location = new System.Drawing.Point(93, 364);
			this.SearchXMLDataButton3.Name = "SearchXMLDataButton3";
			this.SearchXMLDataButton3.Size = new System.Drawing.Size(75, 23);
			this.SearchXMLDataButton3.TabIndex = 5;
			this.SearchXMLDataButton3.Text = "Veri Bul 3";
			this.SearchXMLDataButton3.UseVisualStyleBackColor = true;
			this.SearchXMLDataButton3.Click += new System.EventHandler(this.SearchXMLDataButton3_Click);
			// 
			// DeleteXMLDataButton
			// 
			this.DeleteXMLDataButton.Location = new System.Drawing.Point(255, 306);
			this.DeleteXMLDataButton.Name = "DeleteXMLDataButton";
			this.DeleteXMLDataButton.Size = new System.Drawing.Size(75, 23);
			this.DeleteXMLDataButton.TabIndex = 6;
			this.DeleteXMLDataButton.Text = "Veri Sil";
			this.DeleteXMLDataButton.UseVisualStyleBackColor = true;
			this.DeleteXMLDataButton.Click += new System.EventHandler(this.DeleteXMLDataButton_Click);
			// 
			// AddXMLDataButton
			// 
			this.AddXMLDataButton.Location = new System.Drawing.Point(336, 306);
			this.AddXMLDataButton.Name = "AddXMLDataButton";
			this.AddXMLDataButton.Size = new System.Drawing.Size(75, 23);
			this.AddXMLDataButton.TabIndex = 7;
			this.AddXMLDataButton.Text = "Veri Ekle";
			this.AddXMLDataButton.UseVisualStyleBackColor = true;
			this.AddXMLDataButton.Click += new System.EventHandler(this.AddXMLDataButton_Click);
			// 
			// SQLToXMLButton
			// 
			this.SQLToXMLButton.Location = new System.Drawing.Point(417, 306);
			this.SQLToXMLButton.Name = "SQLToXMLButton";
			this.SQLToXMLButton.Size = new System.Drawing.Size(75, 23);
			this.SQLToXMLButton.TabIndex = 8;
			this.SQLToXMLButton.Text = "SQL to XML";
			this.SQLToXMLButton.UseVisualStyleBackColor = true;
			this.SQLToXMLButton.Click += new System.EventHandler(this.SQLToXMLButton_Click);
			// 
			// XMLToSQLButton
			// 
			this.XMLToSQLButton.Location = new System.Drawing.Point(417, 335);
			this.XMLToSQLButton.Name = "XMLToSQLButton";
			this.XMLToSQLButton.Size = new System.Drawing.Size(75, 23);
			this.XMLToSQLButton.TabIndex = 9;
			this.XMLToSQLButton.Text = "XML to SQL";
			this.XMLToSQLButton.UseVisualStyleBackColor = true;
			this.XMLToSQLButton.Click += new System.EventHandler(this.XMLToSQLButton_Click);
			// 
			// GenerateXMLSchemaButton
			// 
			this.GenerateXMLSchemaButton.Location = new System.Drawing.Point(498, 306);
			this.GenerateXMLSchemaButton.Name = "GenerateXMLSchemaButton";
			this.GenerateXMLSchemaButton.Size = new System.Drawing.Size(111, 23);
			this.GenerateXMLSchemaButton.TabIndex = 10;
			this.GenerateXMLSchemaButton.Text = "Schema Oluştur";
			this.GenerateXMLSchemaButton.UseVisualStyleBackColor = true;
			this.GenerateXMLSchemaButton.Click += new System.EventHandler(this.GenerateXMLSchemaButton_Click);
			// 
			// SQLToXMLWithSchemaButton
			// 
			this.SQLToXMLWithSchemaButton.Location = new System.Drawing.Point(498, 335);
			this.SQLToXMLWithSchemaButton.Name = "SQLToXMLWithSchemaButton";
			this.SQLToXMLWithSchemaButton.Size = new System.Drawing.Size(111, 52);
			this.SQLToXMLWithSchemaButton.TabIndex = 11;
			this.SQLToXMLWithSchemaButton.Text = "SQL to XML with Schema";
			this.SQLToXMLWithSchemaButton.UseVisualStyleBackColor = true;
			this.SQLToXMLWithSchemaButton.Click += new System.EventHandler(this.SQLToXMLWithSchemaButton_Click);
			// 
			// XMLSchemaValidationButton
			// 
			this.XMLSchemaValidationButton.Location = new System.Drawing.Point(498, 393);
			this.XMLSchemaValidationButton.Name = "XMLSchemaValidationButton";
			this.XMLSchemaValidationButton.Size = new System.Drawing.Size(111, 52);
			this.XMLSchemaValidationButton.TabIndex = 12;
			this.XMLSchemaValidationButton.Text = "XML Schema Validation";
			this.XMLSchemaValidationButton.UseVisualStyleBackColor = true;
			this.XMLSchemaValidationButton.Click += new System.EventHandler(this.XMLSchemaValidationButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 460);
			this.Controls.Add(this.XMLSchemaValidationButton);
			this.Controls.Add(this.SQLToXMLWithSchemaButton);
			this.Controls.Add(this.GenerateXMLSchemaButton);
			this.Controls.Add(this.XMLToSQLButton);
			this.Controls.Add(this.SQLToXMLButton);
			this.Controls.Add(this.AddXMLDataButton);
			this.Controls.Add(this.DeleteXMLDataButton);
			this.Controls.Add(this.SearchXMLDataButton3);
			this.Controls.Add(this.UpdateXMLDataButton);
			this.Controls.Add(this.SearchXMLDataButton2);
			this.Controls.Add(this.SearchXMLDataButton);
			this.Controls.Add(this.ReadDataButton);
			this.Controls.Add(this.XMLDataGridView);
			this.Name = "Form1";
			this.Text = "XML Örnekleri";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.XMLDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView XMLDataGridView;
		private System.Windows.Forms.Button ReadDataButton;
		private System.Windows.Forms.Button SearchXMLDataButton;
		private System.Windows.Forms.Button SearchXMLDataButton2;
		private System.Windows.Forms.Button UpdateXMLDataButton;
		private System.Windows.Forms.Button SearchXMLDataButton3;
		private System.Windows.Forms.Button DeleteXMLDataButton;
		private System.Windows.Forms.Button AddXMLDataButton;
		private System.Windows.Forms.Button SQLToXMLButton;
		private System.Windows.Forms.Button XMLToSQLButton;
		private System.Windows.Forms.Button GenerateXMLSchemaButton;
		private System.Windows.Forms.Button SQLToXMLWithSchemaButton;
		private System.Windows.Forms.Button XMLSchemaValidationButton;
	}
}

