using Autofac;
using Autofac.Core;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Data;
using Nop.Plugin.Misc.ExtendedRewardPointsProgram.Domain;
using Nop.Plugin.Misc.ExtendedRewardPointsProgram.Services;
using Nop.Services.Configuration;

namespace Nop.Plugin.Misc.ExtendedRewardPointsProgram.Infrastructure
{
    /// <summary>
    /// Represents dependency registrar
    /// </summary>
    public class DependencyRegistrar : IDependencyRegistrar
    {
        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="typeFinder">Type finder</param>
        /// <param name="appSettings">App settings</param>
        public void Register(IServiceCollection services, ITypeFinder typeFinder, AppSettings appSettings)
        {
            //register custom services
            services.AddScoped<IRewardPointsOnDateSettingsService, RewardPointsOnDateSettingsService>();
        }

        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="builder">Container builder</param>
        /// <param name="typeFinder">Type finder</param>
        /// <param name="config">Config</param>
        //public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        //{
        //    //register override services
        //    builder.RegisterType<ExtendedRewardPointsProgramSettingService>().As<ISettingService>().InstancePerLifetimeScope();
        //}

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        public int Order => 1;
    }
}
