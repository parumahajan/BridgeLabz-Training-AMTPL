using System;

namespace BridgeLabz_Training._3_Address_Book_Problem.Models
{

    public class Contact : IEquatable<Contact>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}".Trim();

        public bool Equals(Contact? other)
        {
            if (other is null) return false;
            return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase) &&
                   LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase) &&
                   Phone.Equals(other.Phone, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object? obj) => Equals(obj as Contact);
        public override int GetHashCode() => HashCode.Combine(FirstName.ToLower(), LastName.ToLower(), Phone);

        public override string ToString()
            => $"{FullName} | {Address}, {City}, {State}, {Zip} | Phone: {Phone} | Email: {Email}";
    }
}