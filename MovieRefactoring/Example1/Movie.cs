namespace org.vijay.Example1
{
    internal class Movie
    {
        public const int CHILDRENS = 2, REGULAR = 0, NEW_RELEASE = 1;
        private readonly string _title;

        public Movie(string title, int priceCode)
        {
            _title = title;
            PriceCode = priceCode;
        }

        public string Title
        {
            get { return _title; }
        }

        public int PriceCode { get; set; }
    }
}