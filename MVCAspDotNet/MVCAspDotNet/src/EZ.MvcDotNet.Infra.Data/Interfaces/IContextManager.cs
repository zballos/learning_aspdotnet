using EZ.MvcDotNet.Infra.Data.Context;

namespace EZ.MvcDotNet.Infra.Data.Interfaces
{
    public interface IContextManager
    {
        MvcDotNetContext GetContext();
    }
}