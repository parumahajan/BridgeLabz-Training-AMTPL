using BridgeLabz_Training._3_Address_Book_Problem.Services;
using BridgeLabz_Training._3_Address_Book_Problem.Utils;
using BridgeLabz_Training._3_Address_Book_Problem.Models;

namespace BridgeLabz_Training._3_Address_Book_Problem.UI
{

    public class Address_Book_Main
    {
        private static AddressBook manager = new();
        private static IDataService storage = new JsonFileService();

        public static async Task Main()
        {
            Console.WriteLine("Welcome to Address Book App\n");
            await Load();

            while (true)
            {
                Console.WriteLine("1 Add  2 Edit  3 Delete  4 View  5 Search  6 Count  7 Sort  8 Storage  9 Exit");
                Console.Write("Enter choice: ");

                switch (Console.ReadLine())
                {
                    case "1": Add(); break;
                    case "2": Edit(); break;
                    case "3": Delete(); break;
                    case "4": View(); break;
                    case "5": Search(); break;
                    case "6": Count(); break;
                    case "7": Sort(); break;
                    case "8": ChooseStorage(); break;
                    case "9": await Save(); return;
                }
            }
        }

        static async Task Load()
        {
            var data = await storage.LoadAsync();
            foreach (var book in data)
                foreach (var c in book.Value)
                    manager.AddContact(book.Key, c);
        }

        static async Task Save()
        {
            await storage.SaveAsync(manager.GetAllAddressBooks());
            Console.WriteLine("Saved. Bye.");
        }

        static void Add()
        {
            string book = InputHelper.GetRequiredString("Book Name");

            var c = new Contact
            {
                FirstName = InputHelper.GetRequiredString("First Name"),
                LastName = InputHelper.GetRequiredString("Last Name"),
                Address = InputHelper.GetOptionalString("Address"),
                City = InputHelper.GetOptionalString("City"),
                State = InputHelper.GetOptionalString("State"),
                Zip = InputHelper.GetOptionalString("Zip"),
                Phone = InputHelper.GetRequiredString("Phone"),
                Email = InputHelper.GetOptionalString("Email")
            };

            Console.WriteLine(manager.AddContact(book, c) ? "Added!\n" : "Duplicate!\n");
        }

        static void Edit()
        {
            string book = InputHelper.GetRequiredString("Book");
            string fn = InputHelper.GetRequiredString("First");
            string ln = InputHelper.GetRequiredString("Last");

            bool ok = manager.EditContact(book, fn, ln, c =>
            {
                c.Phone = InputHelper.GetOptionalString($"Phone ({c.Phone})");
                c.Email = InputHelper.GetOptionalString($"Email ({c.Email})");
            });

            Console.WriteLine(ok ? "Updated!\n" : "Not found\n");
        }

        static void Delete()
        {
            string b = InputHelper.GetRequiredString("Book");
            string f = InputHelper.GetRequiredString("First");
            string l = InputHelper.GetRequiredString("Last");

            Console.WriteLine(manager.DeleteContact(b, f, l) ? "Deleted\n" : "Not found\n");
        }

        static void View()
        {
            foreach (var book in manager.GetAllAddressBooks())
            {
                Console.WriteLine($"\n[{book.Key}]");
                foreach (var c in book.Value)
                    Console.WriteLine(c);
            }
            Console.WriteLine();
        }

        static void Search()
        {
            string loc = InputHelper.GetRequiredString("City or State");
            var r = manager.SearchByLocation(loc);
            r.ForEach(Console.WriteLine);
            Console.WriteLine();
        }

        static void Count()
        {
            Console.WriteLine("By City:");
            foreach (var x in manager.CountByCity()) Console.WriteLine($"{x.Key}: {x.Value}");

            Console.WriteLine("\nBy State:");
            foreach (var x in manager.CountByState()) Console.WriteLine($"{x.Key}: {x.Value}");
            Console.WriteLine();
        }

        static void Sort()
        {
            string b = InputHelper.GetRequiredString("Book");
            Console.Write("1 Name 2 City 3 State 4 Zip: ");
            var opt = Console.ReadLine();

            List<Contact> s = opt switch
            {
                "1" => manager.SortByName(b),
                "2" => manager.SortByCity(b),
                "3" => manager.SortByState(b),
                "4" => manager.SortByZip(b),
                _ => new()
            };

            s.ForEach(Console.WriteLine);
            Console.WriteLine();
        }

        static void ChooseStorage()
        {
            Console.Write("1 Text 2 CSV 3 JSON 4 API 5 DB: ");
            storage = Console.ReadLine() switch
            {
                "1" => new TextFileService(),
                "2" => new CsvService(),
                "3" => new JsonFileService(),
                "4" => new ApiService(),
                "5" => new DatabaseService(),
                _ => storage
            };

            Console.WriteLine("Storage switched.\n");
        }
    }
}