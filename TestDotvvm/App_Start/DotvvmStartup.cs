using DotVVM.Framework.Configuration;
using DotVVM.Framework.ResourceManagement;
using Microsoft.Extensions.DependencyInjection;

namespace TestDotvvm.App_Start
{
    public class DotvvmStartup : IDotvvmStartup, IDotvvmServiceConfigurator
    {
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            ConfigureRoutes(config, applicationPath);
            ConfigureControls(config, applicationPath);
            ConfigureResources(config, applicationPath);
        }

        private void ConfigureResources(DotvvmConfiguration config, string applicationPath)
        {
            // CSS resources
            config.Resources.Register("bootstrap-css", new StylesheetResource()
            {
                Location = new UrlResourceLocation("~/css/bootstrap.css")
            });
            config.Resources.Register("jquery-css", new StylesheetResource()
            {
                Location = new UrlResourceLocation("~/css/jquery-ui.css")
            });
            config.Resources.Register("popper", new ScriptResource()
            {
                Location = new UrlResourceLocation("~/script/popper.min.js"),
                RenderPosition = ResourceRenderPosition.Head
            });
            config.Resources.Register("datatables-css", new StylesheetResource()
            {
                Location = new UrlResourceLocation("~/css/datatables.min.css")
            });
            config.Resources.Register("datatables-responsive-css", new StylesheetResource()
            {
                Location = new UrlResourceLocation("~/css/responsive.dataTables.css")
            });
            config.Resources.Register("datatables-bootstrap4-css", new StylesheetResource()
            {
                Location = new UrlResourceLocation("~/css/dataTables.bootstrap4.css")
            });
            config.Resources.Register("datatables-jqueryui-css", new StylesheetResource()
            {
                Location = new UrlResourceLocation("~/css/dataTables.jqueryui.css")
            });
            config.Resources.Register("simtech-glyphicons-css", new StylesheetResource()
            {
                Location = new UrlResourceLocation("~/css/glyphicons.css")
            });

            // Script resources
            config.Resources.Register("jquery", new ScriptResource()
            {
                Location = new UrlResourceLocation("~/script/jquery-3.4.1.min.js"),
                Dependencies = new[] { "jquery-css" },
                RenderPosition = ResourceRenderPosition.Head
            });
            config.Resources.Register("popper", new ScriptResource()
            {
                Location = new UrlResourceLocation("~/script/umd/popper.min.js"),
                RenderPosition = ResourceRenderPosition.Head
            });
            config.Resources.Register("bootstrap", new ScriptResource()
            {
                Location = new UrlResourceLocation("~/script/bootstrap.min.js"),
                Dependencies = new[] { "bootstrap-css", "jquery", "popper" },
                RenderPosition = ResourceRenderPosition.Head
            });
            config.Resources.Register("datatables", new ScriptResource()
            {
                Location = new UrlResourceLocation("~/script/datatables.min.js"),
                Dependencies = new[] { "datatables-css", "datatables-responsive-css", "datatables-bootstrap4-css", "datatables-jqueryui-css", "jquery" },
                RenderPosition = ResourceRenderPosition.Head
            });
            config.Resources.Register("datetime-moment", new ScriptResource()
            {
                Location = new UrlResourceLocation("~/script/datetime-moment.js"),
                Dependencies = new[] { "moment" },
                RenderPosition = ResourceRenderPosition.Head
            });
            config.Resources.Register("moment", new ScriptResource()
            {
                Location = new UrlResourceLocation("~/script/moment.min.js"),
                RenderPosition = ResourceRenderPosition.Head
            });
        }

        private void ConfigureControls(DotvvmConfiguration config, string applicationPath)
        {
            config.Markup.AddMarkupControl("cc", "Test", "Controls/TestControl.dotcontrol");
        }

        private void ConfigureRoutes(DotvvmConfiguration config, string applicationPath)
        {
            config.RouteTable.Add("Default", "", "Views/Test.dothtml");
            config.RouteTable.Add("Test", "Test", "Views/Test.dothtml");
        }

        public void ConfigureServices(IDotvvmServiceCollection options)
        {
            options.AddDefaultTempStorages("Temp");
        }
    }
}