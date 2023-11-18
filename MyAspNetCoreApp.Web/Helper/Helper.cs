namespace MyAspNetCoreApp.Web.Helper
{
    public class Helper : IHelper
    {
        public string Upper(string text)
        {
            return text.ToUpper();
        }
    }
}
