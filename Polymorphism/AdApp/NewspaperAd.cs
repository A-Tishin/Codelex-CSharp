namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;
        private int _prints;

        public NewspaperAd(int fee, int column, int rate, int prints) : base(fee)
        {
            _rate = rate;
            _column = column;
            _prints = prints;
        }

        public override double Cost()
        {
            return base.Cost() +_column * _rate * _prints;
        }

        public override string ToString()
        {
            return "Newspaper price: " + Cost();
        }
    }
}