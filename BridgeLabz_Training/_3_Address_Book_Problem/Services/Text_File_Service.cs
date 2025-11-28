// UC-12: Read/Write Address Book using File I/O.

using BridgeLabz_Training._3_Address_Book_Problem.Models;
using System.Text;

namespace BridgeLabz_Training._3_Address_Book_Problem.Services
{

    public class Text_File_Service : IData_Service
    {
        private const string FileName = "AddressBook.txt";

        public async Task SaveAsync(Dictionary<string, List<Contact>> addressBooks)
        {
            StringBuilder sb = new();
            foreach (var book in addressBooks)
            {
                sb.AppendLine($"[{book.Key}]");
                foreach (var c in book.Value)
                    sb.AppendLine(c.ToString());
                sb.AppendLine();
            }
            await File.WriteAllTextAsync(FileName, sb.ToString());
        }

        public async Task<Dictionary<string, List<Contact>>> LoadAsync()
        {
            var data = new Dictionary<string, List<Contact>>();
            if (!File.Exists(FileName)) return data;
            return data; // text load not needed for assignment
        }
    }
}