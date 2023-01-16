namespace ExtensionMethodsMapper.Shared
{
	/// <summary>
	/// Represents all the customer details, used when retrieving a full customer details by its id
	/// </summary>
	public class CustomerDetailsDto
	{
        public int Id { get; set; }
        public string? Name { get; set; }
		public string? Phone { get; set; }
		public string? Website { get; set; }
		public IEnumerable<AddressDto>? Addresses { get; set; }
	}
}