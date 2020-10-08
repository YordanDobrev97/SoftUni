namespace SIS.MvcFramework.ViewEngine
{
    public interface IViewEngine
    {
        string GetHtml(string template, object viewModel);
    }
}
