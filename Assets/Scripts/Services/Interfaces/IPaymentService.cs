using Cysharp.Threading.Tasks;

public interface IPaymentService
{
    UniTask InitializeAsync(ServiceSettings settings);
}
