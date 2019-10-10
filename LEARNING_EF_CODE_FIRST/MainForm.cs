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
		private Models.DatabaseContext MyDatabaseContext { get; set; }
		// **********

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			try
			{
				MyDatabaseContext =
					new Models.DatabaseContext();

				var countries =
					MyDatabaseContext.Countries
					.OrderBy(current => current.Name)
					.ToList()
					;

				countriesListBox.ValueMember = nameof(Models.Country.Id);
				countriesListBox.DisplayMember = nameof(Models.Country.Name);

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
			// این احمقانه‌ترین روش کست می‌باشد
			//Models.Country selectedCountry =
			//	(Models.Country)countriesListBox.SelectedItem;

			//if(countriesListBox.SelectedItem is Models.Country)
			//{
			//	Models.Country selectedCountry =
			//		(Models.Country)countriesListBox.SelectedItem;
			//}

			Models.Country selectedCountry =
				countriesListBox.SelectedItem as Models.Country;

			if (selectedCountry != null)
			{
				statesListBox.DataSource = null;

				statesListBox.ValueMember = nameof(Models.State.Id);
				statesListBox.DisplayMember = nameof(Models.State.Name);

				statesListBox.DataSource = selectedCountry.States;
			}
		}

		private void MainForm_FormClosing
			(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			if (MyDatabaseContext != null)
			{
				MyDatabaseContext.Dispose();
				//MyDatabaseContext = null;
			}
		}
	}
}
