using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ML.ProtectOS.Application;
using ML.ProtectOS.Application.Interface;
using ML.ProtectOS.Domain.Interfaces.Repositories;
using ML.ProtectOS.Domain.Interfaces.Services;
using ML.ProtectOS.Domain.Services;
using ML.ProtectOS.Infra.CrossCutting.Identity.Configuration;
using ML.ProtectOS.Infra.CrossCutting.Identity.Context;
using ML.ProtectOS.Infra.CrossCutting.Identity.Model;
using ML.ProtectOS.Infra.Data.Repositories;
using SimpleInjector;
namespace ML.ProtectOS.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {

            container.Register<ApplicationDbContext>();
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
            container.Register<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());
            container.Register<ApplicationRoleManager>();
            container.Register<ApplicationUserManager>();
            container.Register<ApplicationSignInManager>();


            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>), Lifestyle.Scoped);
            container.Register(typeof(IClienteRepository), typeof(ClienteRepository), Lifestyle.Scoped);
            container.Register(typeof(IProdutoRepository), typeof(ProdutoRepository), Lifestyle.Scoped);
            container.Register(typeof(IUsuarioRepository), typeof(UsuarioRepository), Lifestyle.Scoped);

            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>), Lifestyle.Scoped);
            container.Register(typeof(IClienteService), typeof(ClienteService), Lifestyle.Scoped);
            container.Register(typeof(IProdutoService), typeof(ProdutoService), Lifestyle.Scoped);

            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>), Lifestyle.Scoped);
            container.Register(typeof(IClienteAppService), typeof(ClienteAppService), Lifestyle.Scoped);
            container.Register(typeof(IProdutoAppService), typeof(ProdutoAppService), Lifestyle.Scoped);
        }
    }
}
