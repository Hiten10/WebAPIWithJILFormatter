using Ninject;
using System.Web.Http.Dependencies;

namespace WebAPIWithJILFormatter.Ioc
{
    public class NinjectDependancyResolver : NinjectScope, IDependencyResolver
    {
        private IKernel _kernel;
        public NinjectDependancyResolver(IKernel kernel)
            : base(kernel)
        {
            _kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectScope(_kernel.BeginBlock());
        }
    }
}