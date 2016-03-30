using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoTaFeito.ControleDeUsuario.Startup))]
namespace ProjetoTaFeito.ControleDeUsuario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
