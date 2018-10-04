namespace Models
{
	public class State : BaseEntity
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<State>
		{
			public Configuration() : base()
			{
				HasRequired(current => current.Country)
					.WithMany(country => country.States)
					.HasForeignKey(current => current.CountryId)
					.WillCascadeOnDelete(false);
			}
		}
		#endregion /Configuration

		public State() : base()
		{
		}

		// **********
		// **********
		// **********
		public System.Guid CountryId { get; set; }
		// **********

		// **********
		public virtual Country Country { get; set; }
		// **********
		// **********
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]
		public string Name { get; set; }
		// **********
	}
}
