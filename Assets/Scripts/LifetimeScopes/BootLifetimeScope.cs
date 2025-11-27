using System;
using VContainer;
using VContainer.Unity;
using UnityEngine;

public class BootLifetimeScope : LifetimeScope
{
    [SerializeField]
    AppSettings bootSettings;

    [SerializeField]
    ServiceSettings serviceSettings;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterInstance(bootSettings);
        builder.RegisterInstance(serviceSettings);
        
        builder.Register<AppBootstrapper>(Lifetime.Singleton);
    }
}
