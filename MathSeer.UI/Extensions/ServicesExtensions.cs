using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathSeer.UI.Extensions
{
    public class ServicesExtensions : IServiceProvider
    {
        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public void AddClaims(ServiceCollection services)
        {

        }

        public void AddRepository(ServiceCollection services)
        {

        }
    }
}
