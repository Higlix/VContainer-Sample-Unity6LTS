using Cysharp.Threading.Tasks;
using UnityEngine;
using System;

public class AndroidPaymentService : IPaymentService
{
    public async UniTask InitializeAsync(ServiceSettings settings)
    {
        Debug.Log("Initializing Android Payments...");
        await UniTask.Delay(TimeSpan.FromSeconds(0.5f));
        Debug.Log("Android Payments Initialized.");
    }
}

public class IOSPaymentService : IPaymentService
{
    public async UniTask InitializeAsync(ServiceSettings settings)
    {
        Debug.Log("Initializing iOS Payments...");
        await UniTask.Delay(TimeSpan.FromSeconds(0.5f));
        Debug.Log("iOS Payments Initialized.");
    }
}
