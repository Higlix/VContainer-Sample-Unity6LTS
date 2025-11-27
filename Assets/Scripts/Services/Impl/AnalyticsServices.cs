using Cysharp.Threading.Tasks;
using UnityEngine;
using System;

public class AndroidAnalyticsService : IAnalyticsService
{
    public async UniTask InitializeAsync(ServiceSettings settings)
    {
        Debug.Log($"Initializing Android Analytics with Game: {settings.GetAndroidID}...");
        await UniTask.Delay(TimeSpan.FromSeconds(0.5f));
        Debug.Log("Android Analytics Initialized.");
    }
}

public class IOSAnalyticsService : IAnalyticsService
{
    public async UniTask InitializeAsync(ServiceSettings settings)
    {
        Debug.Log($"Initializing iOS Analytics with Game: {settings.GetIOSID}...");
        await UniTask.Delay(TimeSpan.FromSeconds(0.5f));
        Debug.Log("iOS Analytics Initialized.");
    }
}
