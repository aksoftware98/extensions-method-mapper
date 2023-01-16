using ExtensionMethodsMapper.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);
// Register the customers repository 
builder.Services.AddScoped<ICustomersRepository, CustomersRepository>(); 
var app = builder.Build();


// Get all the customers 
app.MapGet("/api/customers", 
		   (ICustomersRepository customersRepo) => customersRepo.GetAll());

// Get a full customer details by Id
app.MapGet("/api/customers/{id}", 
		   (int id, ICustomersRepository customersRepo) => customersRepo.GetById(id));
app.Run();
