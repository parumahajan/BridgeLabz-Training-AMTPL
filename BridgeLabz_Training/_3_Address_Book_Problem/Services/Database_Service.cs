// UC-17 complete — saving & loading AddressBook data to a real SQLite database, while still following the Open/Closed Principle

using Microsoft.Data.Sqlite;
using BridgeLabz_Training._3_Address_Book_Problem.Models;

namespace BridgeLabz_Training._3_Address_Book_Problem.Services {

    public class Database_Service : IData_Service
    {
        private const string Db = "Data Source=AddressBook.db";

        public async Task SaveAsync(Dictionary<string, List<Contact>> books)
        {
            using var con = new SqliteConnection(Db);
            await con.OpenAsync();
            var cmd = con.CreateCommand();
            cmd.CommandText = @"
        CREATE TABLE IF NOT EXISTS Contacts(
            Book TEXT, First TEXT, Last TEXT, Address TEXT, City TEXT, State TEXT,
            Zip TEXT, Phone TEXT, Email TEXT
        ); DELETE FROM Contacts;";
            await cmd.ExecuteNonQueryAsync();

            foreach (var b in books)
            {
                foreach (var c in b.Value)
                {
                    var insert = con.CreateCommand();
                    insert.CommandText = @"INSERT INTO Contacts VALUES($b,$f,$l,$a,$c,$s,$z,$p,$e)";
                    insert.Parameters.AddWithValue("$b", b.Key);
                    insert.Parameters.AddWithValue("$f", c.FirstName);
                    insert.Parameters.AddWithValue("$l", c.LastName);
                    insert.Parameters.AddWithValue("$a", c.Address);
                    insert.Parameters.AddWithValue("$c", c.City);
                    insert.Parameters.AddWithValue("$s", c.State);
                    insert.Parameters.AddWithValue("$z", c.Zip);
                    insert.Parameters.AddWithValue("$p", c.Phone);
                    insert.Parameters.AddWithValue("$e", c.Email);
                    await insert.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<Dictionary<string, List<Contact>>> LoadAsync()
        {
            var data = new Dictionary<string, List<Contact>>();

            using var con = new SqliteConnection(Db);
            await con.OpenAsync();

            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Contacts";
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                string book = reader.GetString(0);
                var c = new Contact
                {
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Address = reader.GetString(3),
                    City = reader.GetString(4),
                    State = reader.GetString(5),
                    Zip = reader.GetString(6),
                    Phone = reader.GetString(7),
                    Email = reader.GetString(8)
                };

                if (!data.ContainsKey(book))
                    data[book] = new();

                data[book].Add(c);
            }

            return data;
        }
    }
}
