namespace org.vijay.Solution1
{
    internal class Rental
    {
        public Rental(Movie movie, int daysRented)
        {
            Movie = movie;
            DaysRented = daysRented;
        }
        public Movie Movie { get; }
        public int DaysRented { get; }
        public double AmountCharged() => Movie.AmountFor(DaysRented);
        public int FrequentRenterPoints() => Movie.FrequentRenterPoints(DaysRented);
    }
}