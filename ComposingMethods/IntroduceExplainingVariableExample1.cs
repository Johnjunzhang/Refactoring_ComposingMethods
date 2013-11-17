namespace Composing_Methods
{
    public class IntroduceExplainingVariableExample1
    {
        public bool IsResizableIEInMac(string platform, string browser, int resize)
        {
            return platform.IndexOf("MAC") > -1 && browser.IndexOf("IE") > -1 && resize > 0;
        }
    }
}