using Cysharp.Threading.Tasks;
using UnityEngine;
using System;

public class AndroidAdsService : IAdsService
{
    public async UniTask InitializeAsync(ServiceSettings settings)
    {
        Debug.Log("Initializing Android Ads...");
        await UniTask.Delay(TimeSpan.FromSeconds(0.5f));
        Debug.Log("Android Ads Initialized.");
    }
}

public class IOSAdsService : IAdsService
{
    public async UniTask InitializeAsync(ServiceSettings settings)
    {
        Debug.Log("Initializing iOS Ads...");
        await UniTask.Delay(TimeSpan.FromSeconds(0.5f));
        Debug.Log("iOS Ads Initialized.");
    }
}
