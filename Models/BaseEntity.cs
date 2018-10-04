namespace Models
{
	public abstract class BaseEntity : object
	{
		public BaseEntity()
		{
			Id = System.Guid.NewGuid();
		}

		// **********
		public System.Guid Id { get; set; }
		// **********
	}
}
