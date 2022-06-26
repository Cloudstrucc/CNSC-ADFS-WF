using System;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Logging;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.WsFederation;
using Owin;

namespace CNSC_ADFS_WF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            IdentityModelEventSource.ShowPII = true;
        }
        //public void Configuration(IAppBuilder app)

        //{

        //    app.UseCookieAuthentication(

        //    new CookieAuthenticationOptions

        //    {

        //        AuthenticationType = WsFederationAuthenticationDefaults.AuthenticationType


        //    });

        //    app.UseWsFederationAuthentication(

        //    new WsFederationAuthenticationOptions

        //    {


        //        MetadataAddress = ConfigurationManager.AppSettings["ida:ADFSMetadata"],

        //        Wtrealm = ConfigurationManager.AppSettings["ida:Wtrealm"]



        //    });



        //    app.SetDefaultSignInAsAuthenticationType(WsFederationAuthenticationDefaults.AuthenticationType);

        //}
    }
}
