namespace ValidationAttributes
{

    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minAge;
        private int maxAge;

        public MyRangeAttribute(int minAge, int maxAge)
        {
            this.minAge = minAge;
            this.maxAge = maxAge;
        }

        public override bool IsValid(object obj)
        {
            int currentAge = (int)obj;

            return currentAge > minAge && currentAge < maxAge;
        }
    }
}
