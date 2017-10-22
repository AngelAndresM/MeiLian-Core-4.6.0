using Microsoft.Extensions.Configuration;

namespace MeiLian.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
