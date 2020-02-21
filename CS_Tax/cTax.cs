namespace CS_Tax
{
    class cTax
    {
        public double item1;
        public double mcTax_Rate = 1.17;
        public double GetAmount()
        {
            return item1;
        }

        public double cFindTax(double cAmount)
        {
            double findTax = cAmount - (cAmount * mcTax_Rate);

            return findTax;
        }
    }
}
