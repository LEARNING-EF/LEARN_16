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
			State state = null;
			Country country = null;

			for (int countryIndex = 1; countryIndex <= 5; countryIndex++)
			{
				country =
					new Country()
					{
						Name =
							string.Format("Country ({0})", countryIndex),
					};

				// Note
				country.States =
					new System.Collections.Generic.List<State>();

				for (int stateIndex = 1; stateIndex <= 20000; stateIndex++)
				{
					state =
						new State()
						{
							Name =
								string.Format("Country ({0}) - State ({1})",
								countryIndex, stateIndex),
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
