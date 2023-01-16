namespace ExtensionMethodsMapper.Shared
{
	/// <summary>
	/// Light object represents the customer essential properties, used when retrieving long list of customers to keep the response fast
	/// </summary>
	public class CustomerSummaryDto
	{
		public int Id { get; set; }
		public string? Name { get; set; }
	}
}