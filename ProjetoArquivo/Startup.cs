using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoArquivo.Startup))]
namespace ProjetoArquivo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
