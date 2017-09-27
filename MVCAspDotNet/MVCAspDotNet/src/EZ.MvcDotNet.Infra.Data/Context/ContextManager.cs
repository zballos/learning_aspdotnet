using System.Web;
using EZ.MvcDotNet.Infra.Data.Interfaces;

namespace EZ.MvcDotNet.Infra.Data.Context
{
    public class ContextManager : IContextManager
    {
        private const string ContextKey = "ContextManager.Context";

        // Padrão: One Context Per Request
        public MvcDotNetContext GetContext()
        {
            if (HttpContext.Current.Items[ContextKey] == null)
            {
                HttpContext.Current.Items[ContextKey] = new MvcDotNetContext();
            }

            return (MvcDotNetContext) HttpContext.Current.Items[ContextKey];
        }
    }
}