using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.String;

namespace org.vijay.Solution1
{
    internal class Customer
    {
        public const string NewLIne = "\n";
        public const string TabChar = "\t";
        private readonly List<Rental> _rentals = new List<Rental>();

        public Customer(string name)
        {
            Name = name;
        }
        public void AddRental(Rental arg) => _rentals.Add(arg);
        public string Name { get;  }
        private int TotalFrequentRenterPoints() => _rentals.Sum(r => r.FrequentRenterPoints());
        private double TotalAmount() => _rentals.Sum(r => r.AmountCharged());
        private static string PrintRental(Rental r) => TabChar + r.Movie.Title + TabChar + r.AmountCharged();
        public string Statement() =>
            new StringBuilder("Rental Record for " + Name + NewLIne)
                .Append(Join(NewLIne, _rentals.Select(PrintRental)))
                .Append("Amount owed is " + TotalAmount() + NewLIne)
                .Append("You earned " + TotalFrequentRenterPoints() + " frequent renter points")
                .ToString();
    }
}