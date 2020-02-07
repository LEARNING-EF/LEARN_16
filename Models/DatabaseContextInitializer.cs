namespace Models
{
	internal class DatabaseContextInitializer :
		System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
	{
		public DatabaseContextInitializer() : base()
		{
		}

		protected override void Seed(DatabaseContext databaseContext)
		{
			for (int countryIndex = 1; countryIndex <= 5; countryIndex++)
			{
				Country country =
					new Country()
					{
						Name =
							$"Country ({ countryIndex })",
					};

				// بسیار مهم است. توجه کنید
				country.States =
					new System.Collections.Generic.List<State>();

				for (int stateIndex = 1; stateIndex <= 20000; stateIndex++)
				{
					State state =
						new State()
						{
							Name =
								$"Country ({ countryIndex }) - State ({ stateIndex })",
						};

					country.States.Add(state);
				}

				databaseContext.Countries.Add(country);

				databaseContext.SaveChanges();
			}

			// Optional
			databaseContext.SaveChanges();
		}
	}
}
