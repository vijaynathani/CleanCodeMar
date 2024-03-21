namespace org.vijay.Solution1
{
    internal abstract class Movie
    {
        protected Movie(string title)
        {
            Title = title;
        }

        public string Title { get; }
        public abstract double AmountFor(int daysRented);
        public virtual int FrequentRenterPoints(int daysRented) => 1;
    }

    internal class ChildrensMovie : Movie
    {
        private ChildrensMovie(string title) : base(title)
        {
        }

        public override double AmountFor(int daysRented)
        {
            var r = 1.5;
            if (daysRented > 3)
                r += (daysRented - 3)*1.5;
            return r;
        }
    }

    internal class RegularMovie : Movie
    {
        private RegularMovie(string title) : base(title)
        {
        }

        public override double AmountFor(int daysRented)
        {
            double r = 2;
            if (daysRented > 2)
                r += (daysRented - 2)*1.5;
            return r;
        }
    }

    internal class NewReleaseMovie : Movie
    {
        private NewReleaseMovie(string title) : base(title)
        {
        }

        public override double AmountFor(int daysRented) => daysRented * 3;

        public override int FrequentRenterPoints(int daysRented)
        {
            var r = base.FrequentRenterPoints(daysRented);
            return daysRented > 1 ? r + 1 : r;
        }
    }
}