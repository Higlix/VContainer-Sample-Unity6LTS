using UnityEngine;

[CreateAssetMenu(fileName = "ServiceSettings", menuName = "Service/Settings")]
public class ServiceSettings : ScriptableObject
{
    [Header("General")]
    [SerializeField]
    private string ID_IOS;
    public string GetIOSID => ID_IOS;

    [SerializeField]
    private string ID_Android;
    public string GetAndroidID => ID_Android;

    [SerializeField]
    private string Name;
    public string GameName => Name;


    [Header("Analytics")]
    [SerializeField]
    private string AnalyticsAPIKey;
    public string GetAnalyticsAPIKey => AnalyticsAPIKey;

    [Header("Ads")]
    [SerializeField]
    private string AdsAPIKey;
    public string GetAdsAPIKey => AdsAPIKey;

    [Header("Payments")]
    [SerializeField]
    private string PaymentsAPIKey;
    public string GetPaymentsAPIKey => PaymentsAPIKey;
    
}
