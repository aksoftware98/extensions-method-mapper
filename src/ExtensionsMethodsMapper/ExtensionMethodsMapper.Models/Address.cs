namespace ExtensionMethodsMapper.Models;

public class Address
{
	public int Id { get; set; }
	public string? AddressLine1 { get; set; }
	public string? AddressLine2 { get; set; }
	public string? City { get; set; }
	public string? State { get; set; }
	public string? ZipCode { get; set; }
	public string? Country { get; set; }
	
	public DateTimeOffset CreationDate { get; set; }
	public DateTimeOffset ModificationDate { get; set; }
	public string? CreatedByUserId { get; set; }
	public string? ModifiedByUserId { get; set; }

}
