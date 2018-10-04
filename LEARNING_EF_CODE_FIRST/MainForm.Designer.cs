namespace LEARNING_EF_CODE_FIRST
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			if (databaseContext != null)
			{
				databaseContext.Dispose();
				databaseContext = null;
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
			this.countriesListBox = new System.Windows.Forms.ListBox();
			this.statesListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// countriesListBox
			// 
			this.countriesListBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.countriesListBox.FormattingEnabled = true;
			this.countriesListBox.Location = new System.Drawing.Point(0, 0);
			this.countriesListBox.Name = "countriesListBox";
			this.countriesListBox.Size = new System.Drawing.Size(455, 160);
			this.countriesListBox.TabIndex = 0;
			this.countriesListBox.SelectedIndexChanged += new System.EventHandler(this.CountriesListBox_SelectedIndexChanged);
			// 
			// statesListBox
			// 
			this.statesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.statesListBox.FormattingEnabled = true;
			this.statesListBox.Location = new System.Drawing.Point(0, 160);
			this.statesListBox.Name = "statesListBox";
			this.statesListBox.Size = new System.Drawing.Size(455, 237);
			this.statesListBox.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 397);
			this.Controls.Add(this.statesListBox);
			this.Controls.Add(this.countriesListBox);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox countriesListBox;
		private System.Windows.Forms.ListBox statesListBox;
	}
}
