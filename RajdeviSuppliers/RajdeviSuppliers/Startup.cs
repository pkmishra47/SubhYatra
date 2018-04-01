using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RajdeviSuppliers.Startup))]
namespace RajdeviSuppliers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
