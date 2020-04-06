using Microsoft.Owin;
using Owin;
using System.Web.Hosting;

[assembly: OwinStartup(typeof(TestDotvvm.App_Start.Startup))]

namespace TestDotvvm.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
                var applicationPhysicalPath = HostingEnvironment.ApplicationPhysicalPath;

                // Set up DotVVM
                var dotvvmConfiguration = app.UseDotVVM<DotvvmStartup>(applicationPhysicalPath, debug: IsInDebugMode());
        }

            private bool IsInDebugMode()
            {
#if !DEBUG
			return false;
#endif
                return true;
            }
    }
}
