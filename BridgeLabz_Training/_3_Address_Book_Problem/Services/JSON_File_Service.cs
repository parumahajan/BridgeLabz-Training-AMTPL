// UC-14: JSON read/write

using BridgeLabz_Training._3_Address_Book_Problem.Models;
using System.Text.Json;

namespace BridgeLabz_Training._3_Address_Book_Problem.Services {

    public class JSON_File_Service : IData_Service
    {
        private const string FileName = "AddressBook.json";

        public async Task SaveAsync(Dictionary<string, List<Contact>> addressBooks)
        {
            var json = JsonSerializer.Serialize(addressBooks, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(FileName, json);
        }

        public async Task<Dictionary<string, List<Contact>>> LoadAsync()
        {
            if (!File.Exists(FileName)) return new();
            var json = await File.ReadAllTextAsync(FileName);
            return JsonSerializer.Deserialize<Dictionary<string, List<Contact>>>(json) ?? new();
        }
    }
}