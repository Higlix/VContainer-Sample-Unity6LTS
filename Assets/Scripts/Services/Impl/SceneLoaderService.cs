using Cysharp.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoaderService : ISceneLoaderService
{
    public async UniTask LoadSceneAsync(string sceneName, bool showLoadingScreen = true)
    {
        // TODO: Implement Loading Screen logic here
        if (showLoadingScreen)
        {
            Debug.Log($"[SceneLoader] Loading scene '{sceneName}' with loading screen...");
        }
        else
        {
            Debug.Log($"[SceneLoader] Loading scene '{sceneName}'...");
        }

        await SceneManager.LoadSceneAsync(sceneName).ToUniTask();
        
        Debug.Log($"[SceneLoader] Loaded '{sceneName}'.");
    }
}

