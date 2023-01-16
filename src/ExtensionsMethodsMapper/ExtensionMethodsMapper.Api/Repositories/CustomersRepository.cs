using ExtensionMethodsMapper.Models;

namespace ExtensionMethodsMapper.Api.Repositories
{
	public class CustomersRepository : ICustomersRepository
	{

		private static List<Customer> _customers = new()
		{
			new Customer
			{
				Id = 1,
				FirstName = "John",
				LastName = "Doe",
				Birthdate = new DateOnly(1990, 01, 03),
				CompanyName = "JDoe Inc.",
				CreatedByUserId = Guid.NewGuid().ToString(),
				Phone = "555-555-5555",
				Website = "https://www.jdoe.com",
				Addresses = new List<Address>
				{
					new Address
					{
						Id = 1,
						AddressLine1 = "123 Main St.",
						City = "Anytown",
						State = "CA",
						ZipCode = "12345",
						Country = "USA",
					},
					new Address
					{
						Id = 2,
						AddressLine1 = "456 St.",
						City = "Another town",
						State = "TX",
						ZipCode = "12345",
						Country = "USA",
					}
				}
			},
			new Customer
			{
				Id = 2,
				FirstName = "Jane",
				LastName = "Doe",
				Birthdate = new DateOnly(1993, 05, 03),
				CompanyName = "JaneD Inc.",
				CreatedByUserId = Guid.NewGuid().ToString(),
				Phone = "555-555-4444",
				Website = "https://www.janedoe.com"
			},
			new Customer
			{
				Id = 3,
				FirstName = "John",
				LastName = "Smith",
				Birthdate = new DateOnly(1984, 02, 13),
				CompanyName = "JohnS Inc.",
				CreatedByUserId = Guid.NewGuid().ToString(),
				Phone = "555-555-3333",
				Website = "https://www.johnsmith.com",
				Addresses = new List<Address>
				{
					new Address
					{
						Id = 1,
						AddressLine1 = "123 Main St.",
						City = "Anytown",
						State = "CA",
						ZipCode = "12345",
						Country = "USA",
					},
					new Address
					{
						Id = 2,
						AddressLine1 = "456 St.",
						City = "Another town",
						State = "TX",
						ZipCode = "12345",
						Country = "USA",
					}
				}
			}
		};

		public IEnumerable<Customer> GetAll()
		{
			return _customers
						.Select(c => new Customer()
						{
							Id = c.Id,
							FirstName = c.FirstName,
							LastName = c.LastName,
							Birthdate = c.Birthdate,
						});
		}

		public Customer? GetById(int id)
		{
			return _customers
						.FirstOrDefault(c => c.Id == id);
		}
	}
}
