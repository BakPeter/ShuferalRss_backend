using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicLoaderContracts
{
    public interface IDynamicLoaderService
    {
        void LoadServices(IServiceCollection services, string path);
    }
}
