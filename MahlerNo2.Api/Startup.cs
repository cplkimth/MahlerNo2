using System;
using System.Web.Http;
using Owin;

namespace MahlerNo2.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder) 
        { 
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration(); 
            
            config.Formatters.JsonFormatter.MediaTypeMappings
                .Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept", 
                    "text/html",
                    StringComparison.InvariantCultureIgnoreCase,
                    true, 
                    "application/json"));

            config.Routes.MapHttpRoute( 
                name: "DefaultApi", 
                routeTemplate: "api/{controller}/{date}/{time}", 
                defaults: new { date = RouteParameter.Optional, time = RouteParameter.Optional } 
            ); 

            appBuilder.UseWebApi(config); 
        } 
    }
}