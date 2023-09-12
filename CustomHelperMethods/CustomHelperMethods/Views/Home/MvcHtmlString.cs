namespace CustomHelperMethods.Views.Home
{
    internal class MvcHtmlString : IHtmlString
    {
        private string? v;

        public MvcHtmlString(string? v)
        {
            this.v = v;
        }
    }
}