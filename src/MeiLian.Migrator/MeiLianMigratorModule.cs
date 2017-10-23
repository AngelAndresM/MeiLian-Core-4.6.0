using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using MeiLian.Configuration;
using MeiLian.EntityFrameworkCore;
using MeiLian.Migrator.DependencyInjection;

namespace MeiLian.Migrator
{
    [DependsOn(typeof(MeiLianEntityFrameworkCoreModule))]
    public class MeiLianMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MeiLianMigratorModule(MeiLianEntityFrameworkCoreModule MeiLianEntityFrameworkCoreModule)
        {
            MeiLianEntityFrameworkCoreModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MeiLianMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MeiLianConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MeiLianMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
