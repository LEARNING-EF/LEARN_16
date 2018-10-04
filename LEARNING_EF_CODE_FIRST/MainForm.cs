using System.Linq;

namespace LEARNING_EF_CODE_FIRST
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		// **********
		// **********
		// **********
		private Models.DatabaseContext databaseContext;
		// **********

		// **********
		protected virtual Models.DatabaseContext DatabaseContext
		{
			get
			{
				if (databaseContext == null)
				{
					databaseContext =
						new Models.DatabaseContext();
				}

				return databaseContext;
			}
		}
		// **********
		// **********
		// **********

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			try
			{
				var countries =
					DatabaseContext.Countries
					.OrderBy(current => current.Name)
					.ToList()
					;

				countriesListBox.ValueMember = "Id";
				countriesListBox.DisplayMember = "Name";
				countriesListBox.DataSource = countries;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
			}
		}

		private void CountriesListBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Models.Country selectedCountry =
				countriesListBox.SelectedItem as Models.Country;

			if (selectedCountry != null)
			{
				statesListBox.DataSource = null;

				statesListBox.ValueMember = "Id";
				statesListBox.DisplayMember = "Name";
				statesListBox.DataSource = selectedCountry.States;
			}
		}

		private void MainForm_FormClosing
			(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			if (databaseContext != null)
			{
				databaseContext.Dispose();
				databaseContext = null;
			}
		}
	}
}
