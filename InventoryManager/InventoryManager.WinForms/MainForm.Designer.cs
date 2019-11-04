namespace InventoryManager.WinForms
{
	partial class MainForm
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
			System.Windows.Forms.Label fileLabel;
			this.filenameTextbox = new System.Windows.Forms.TextBox();
			this.selectFileButton = new System.Windows.Forms.Button();
			fileLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// filenameTextbox
			// 
			this.filenameTextbox.Location = new System.Drawing.Point(44, 22);
			this.filenameTextbox.Name = "filenameTextbox";
			this.filenameTextbox.ReadOnly = true;
			this.filenameTextbox.Size = new System.Drawing.Size(929, 20);
			this.filenameTextbox.TabIndex = 0;
			// 
			// fileLabel
			// 
			fileLabel.AutoSize = true;
			fileLabel.Location = new System.Drawing.Point(12, 25);
			fileLabel.Name = "fileLabel";
			fileLabel.Size = new System.Drawing.Size(26, 13);
			fileLabel.TabIndex = 1;
			fileLabel.Text = "File:";
			fileLabel.Click += new System.EventHandler(this.Label1_Click);
			// 
			// selectFileButton
			// 
			this.selectFileButton.Location = new System.Drawing.Point(979, 19);
			this.selectFileButton.Name = "selectFileButton";
			this.selectFileButton.Size = new System.Drawing.Size(33, 25);
			this.selectFileButton.TabIndex = 2;
			this.selectFileButton.Text = "...";
			this.selectFileButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 617);
			this.Controls.Add(this.selectFileButton);
			this.Controls.Add(fileLabel);
			this.Controls.Add(this.filenameTextbox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Inventory Manager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox filenameTextbox;
		private System.Windows.Forms.Button selectFileButton;
	}
}

