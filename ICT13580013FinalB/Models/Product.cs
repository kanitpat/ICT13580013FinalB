using System;
using SQLite;
namespace ICT13580013FinalB.Models
{
    public class Product
    {
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[NotNull]
		[MaxLength(200)]
		public string Name { get; set; }

		[MaxLength(200)]
		public string LastName { get; set; }

		public int Age { get; set; }

		public string Sex { get; set; }

		public string Department { get; set; }

		[MaxLength(10)]
		public int Tel { get; set; }

		public string Email { get; set; }

		public string Address { get; set; }

		public string Status { get; set; }

		public int Child { get; set; }

		public int Saraly { get; set; }


	}
}
