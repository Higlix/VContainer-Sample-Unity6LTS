using Cysharp.Threading.Tasks;
using UnityEngine;
using VContainer;

public class AppBootstrapper
{
    readonly IAnalyticsService analyticsService;
    readonly IAdsService adsService;
    readonly IPaymentService paymentService;
    readonly ServiceSettings serviceSettings;

    [Inject]
    public AppBootstrapper(
        IAnalyticsService analyticsService,
        IAdsService adsService,
        IPaymentService paymentService,
        ServiceSettings serviceSettings)
    {
        this.analyticsService = analyticsService;
        this.adsService = adsService;
        this.paymentService = paymentService;
        this.serviceSettings = serviceSettings;
    }

    public async UniTask BootAsync()
    {
        Debug.Log("Boot Sequence Started...");

        await analyticsService.InitializeAsync(serviceSettings);
        await adsService.InitializeAsync(serviceSettings);
        await paymentService.InitializeAsync(serviceSettings);

        Debug.Log("Boot Sequence Completed!");
    }
}
