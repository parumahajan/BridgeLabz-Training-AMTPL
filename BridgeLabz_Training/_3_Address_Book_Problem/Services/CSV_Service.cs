// UC-13: Read/Write Address Book as CSV

using BridgeLabz_Training._3_Address_Book_Problem.Models;

namespace BridgeLabz_Training._3_Address_Book_Problem.Services
{

    public class CSV_Service : IData_Service
    {
        private const string FileName = "AddressBook.csv";

        public async Task SaveAsync(Dictionary<string, List<Contact>> addressBooks)
        {
            List<string> lines = new() { "Book,First,Last,Address,City,State,Zip,Phone,Email" };

            foreach (var book in addressBooks)
            {
                foreach (var c in book.Value)
                {
                    lines.Add($"{book.Key},{c.FirstName},{c.LastName},{c.Address},{c.City},{c.State},{c.Zip},{c.Phone},{c.Email}");
                }
            }

            await File.WriteAllLinesAsync(FileName, lines);
        }

        public async Task<Dictionary<string, List<Contact>>> LoadAsync()
        {
            return new(); // skip CSV load
        }
    }
}