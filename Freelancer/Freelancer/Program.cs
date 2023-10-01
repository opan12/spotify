using Freelancer.Entities;
using Freelancer.Services;
using Freelancer.Common;
using Freelancer.Abstract;



var anotherCustomerInstance = new Customer
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTimeOffset.Now,
    FirstName = "sude",
    LastName = "opan",
    PhoneNumber = "553-723-0946"
};





NotepadService notepadService = new();

string customerData = notepadService.GetOnNotepad("C:\\Users\\sudeo\\source\\repos\\Freelancer\\Freelancer\\Database\\Costumer.txt");

string[] splittedLines = customerData.Split("\n", StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new();

foreach (var line in splittedLines)
{
    Customer customer = new();
    customer.SetValuesCSV(line);
    customers.Add(customer);
}