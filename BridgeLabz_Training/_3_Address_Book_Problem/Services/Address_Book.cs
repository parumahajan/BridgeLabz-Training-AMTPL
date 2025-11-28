using BridgeLabz-Training._3_Address_Book_Problem.Models;

namespace BridgeLabz_Training._3_Address_Book_Problem.Services {

    public class Address_Book
    {
        private readonly Dictionary<string, List<Contact>> _books = new();

        public bool AddContact(string bookName, Contact contact)
        {
            if (!_books.ContainsKey(bookName))
                _books[bookName] = new();

            if (_books[bookName].Contains(contact))
                return false;

            _books[bookName].Add(contact);
            return true;
        }

        public bool EditContact(string bookName, string first, string last, Action<Contact> update)
        {
            if (!_books.ContainsKey(bookName)) return false;

            var person = _books[bookName]
                .FirstOrDefault(c => c.FirstName == first && c.LastName == last);

            if (person is null) return false;

            update(person);
            return true;
        }

        public bool DeleteContact(string bookName, string first, string last)
        {
            if (!_books.ContainsKey(bookName)) return false;

            var person = _books[bookName]
                .FirstOrDefault(c => c.FirstName == first && c.LastName == last);

            if (person is null) return false;

            _books[bookName].Remove(person);
            return true;
        }

        public Dictionary<string, List<Contact>> GetAllAddressBooks() => _books;

        public List<Contact> SearchByLocation(string location)
        {
            return _books.Values.SelectMany(b => b)
                .Where(c => c.City == location || c.State == location)
                .ToList();
        }

        public Dictionary<string, int> CountByCity()
            => _books.Values.SelectMany(b => b).GroupBy(c => c.City).ToDictionary(g => g.Key, g => g.Count());

        public Dictionary<string, int> CountByState()
            => _books.Values.SelectMany(b => b).GroupBy(c => c.State).ToDictionary(g => g.Key, g => g.Count());

        public List<Contact> SortByName(string book) => _books.GetValueOrDefault(book, new()).OrderBy(c => c.FullName).ToList();
        public List<Contact> SortByCity(string book) => _books.GetValueOrDefault(book, new()).OrderBy(c => c.City).ToList();
        public List<Contact> SortByState(string book) => _books.GetValueOrDefault(book, new()).OrderBy(c => c.State).ToList();
        public List<Contact> SortByZip(string book) => _books.GetValueOrDefault(book, new()).OrderBy(c => c.Zip).ToList();
    }
}