using Ninject.Modules;
using Looks.Domain.Providers;
using Looks.Models;

namespace Looks.DependencyResolver {
    public class DomainModule: NinjectModule {

        public override void Load() {
            this.Bind<IHandler<Product>>().To<Handler<Product>>().InSingletonScope();
            this.Bind<IHandler<ProductOption>>().To<Handler<ProductOption>>().InSingletonScope();
            this.Bind<IHandler<ProductSizeType>>().To<Handler<ProductSizeType>>().InSingletonScope();
            this.Bind<IHandler<User>>().To<Handler<User>>().InSingletonScope();
            this.Bind<IHandler<RequestOrder>>().To<Handler<RequestOrder>>().InSingletonScope();
        }
    }
}
