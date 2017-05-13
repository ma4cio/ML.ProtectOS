using ML.ProtectOS.Application;
using ML.ProtectOS.Application.Interface;
using ML.ProtectOS.Domain.Interfaces.Repositories;
using ML.ProtectOS.Domain.Interfaces.Services;
using ML.ProtectOS.Domain.Services;
using ML.ProtectOS.Infra.Data.Repositories;
using SimpleInjector;
namespace ML.ProtectOS.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {

            //container.RegisterPerWebRequest<ApplicationDbContext>();
            //container.RegisterPerWebRequest<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
            //container.RegisterPerWebRequest<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());
            //container.RegisterPerWebRequest<ApplicationRoleManager>();
            //container.RegisterPerWebRequest<ApplicationUserManager>();
            //container.RegisterPerWebRequest<ApplicationSignInManager>();


            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>), Lifestyle.Scoped);
            container.Register(typeof(IClienteRepository), typeof(ClienteRepository), Lifestyle.Scoped);
            container.Register(typeof(IProdutoRepository), typeof(ProdutoRepository), Lifestyle.Scoped);

            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>), Lifestyle.Scoped);
            container.Register(typeof(IClienteService), typeof(ClienteService), Lifestyle.Scoped);
            container.Register(typeof(IProdutoService), typeof(ProdutoService), Lifestyle.Scoped);

            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>), Lifestyle.Scoped);
            container.Register(typeof(IClienteAppService), typeof(ClienteAppService), Lifestyle.Scoped);
            container.Register(typeof(IProdutoAppService), typeof(ProdutoAppService), Lifestyle.Scoped);
        }
    }
}
