using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DBU_Advising_Scheduler.Startup))]

namespace DBU_Advising_Scheduler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}