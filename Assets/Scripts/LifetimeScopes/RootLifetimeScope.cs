using System;
using VContainer;
using VContainer.Unity;
using UnityEngine;

public class RootLifetimeScope : LifetimeScope
{
    [SerializeField]
    LifetimeScopePrefabs lifetimeScopePrefabs;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterInstance(lifetimeScopePrefabs);

        builder.Register<SceneLoaderService>(Lifetime.Singleton).As<ISceneLoaderService>();

#if UNITY_ANDROID && !UNITY_EDITOR
        builder.Register<AndroidAnalyticsService>(Lifetime.Singleton).As<IAnalyticsService>();
        builder.Register<AndroidAdsService>(Lifetime.Singleton).As<IAdsService>();
        builder.Register<AndroidPaymentService>(Lifetime.Singleton).As<IPaymentService>();
#elif UNITY_IOS && !UNITY_EDITOR
        builder.Register<IOSAnalyticsService>(Lifetime.Singleton).As<IAnalyticsService>();
        builder.Register<IOSAdsService>(Lifetime.Singleton).As<IAdsService>();
        builder.Register<IOSPaymentService>(Lifetime.Singleton).As<IPaymentService>();
#else
        builder.Register<MockAnalyticsService>(Lifetime.Singleton).As<IAnalyticsService>();
        builder.Register<MockAdsService>(Lifetime.Singleton).As<IAdsService>();
        builder.Register<MockPaymentService>(Lifetime.Singleton).As<IPaymentService>();
#endif


        builder.RegisterEntryPoint<SingleEntryPoint>();
    }
}
