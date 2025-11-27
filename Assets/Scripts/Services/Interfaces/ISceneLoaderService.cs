using Cysharp.Threading.Tasks;

public interface ISceneLoaderService
{
    UniTask LoadSceneAsync(string sceneName, bool showLoadingScreen = true);
}

