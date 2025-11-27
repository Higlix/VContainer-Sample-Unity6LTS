using Cysharp.Threading.Tasks;
using UnityEngine;
using System;

public class MockAnalyticsService : IAnalyticsService
{
    public async UniTask InitializeAsync(ServiceSettings settings)
    {
        Debug.Log($"Initializing Mock Analytics for {settings.GameName}...");
        await UniTask.Delay(TimeSpan.FromSeconds(0.1f));
    }
}

public class MockAdsService : IAdsService
{
    public async UniTask InitializeAsync(ServiceSettings settings)
    {
        Debug.Log("Initializing Mock Ads...");
        await UniTask.Delay(TimeSpan.FromSeconds(0.1f));
    }
}

public class MockPaymentService : IPaymentService
{
    public async UniTask InitializeAsync(ServiceSettings settings)
    {
        Debug.Log("Initializing Mock Payment...");
        await UniTask.Delay(TimeSpan.FromSeconds(0.1f));
    }
}
