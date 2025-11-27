using Cysharp.Threading.Tasks;

public interface IAnalyticsService
{
    UniTask InitializeAsync(ServiceSettings settings);
}
