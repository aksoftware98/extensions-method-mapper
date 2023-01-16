namespace ExtensionMethodsMapper.Models;

public class Customer
{
	public int Id { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public string? Phone { get; set; }
	public DateOnly Birthdate { get; set; }
	public IList<Address>? Addresses { get; set; }
	public IList<Order>? Orders { get; set; }
	public DateTimeOffset CreationDate { get; set; }
	public DateTimeOffset ModificationDate { get; set; }
	public string? CreatedByUserId { get; set; }
	public string? ModifiedByUserId { get; set; }
}
