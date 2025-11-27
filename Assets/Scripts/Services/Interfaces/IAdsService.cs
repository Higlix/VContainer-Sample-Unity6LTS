using Cysharp.Threading.Tasks;

public interface IAdsService
{
    UniTask InitializeAsync(ServiceSettings settings);
}
