using ExtensionMethodsMapper.Models;

namespace ExtensionMethodsMapper.Api.Repositories
{
	public interface ICustomersRepository
	{
		IEnumerable<Customer> GetAll();
		Customer? GetById(int id);
	}
}