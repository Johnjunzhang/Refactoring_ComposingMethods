namespace Composing_Methods
{
    public class ReplaceMethodWithMethodObject
    {
        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
            var importantValue1 = inputVal*quantity;
            var importantValue2 = inputVal*yearToDate + 100;
            if ((yearToDate - importantValue1) > 100)
                importantValue2 -= 20;
            var importantValue3 = importantValue2*7;
            return importantValue3 - 2*importantValue1;
        }
    }
}