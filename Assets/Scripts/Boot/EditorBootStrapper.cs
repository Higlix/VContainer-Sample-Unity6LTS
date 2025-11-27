using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
public static class EditorBootStrapper
{
    public static string TargetScene { get; private set; }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Init()
    {
        // Check if the RootLifetimeScope is already in the scene.
        // If it is, we assume we are already in the "Boot" flow or initialized correctly.
        // However, VContainer's RootLifetimeScope is a MonoBehaviour.
        
        // A robust check is to look for the RootLifetimeScope object.
        // Or better: Check if the active scene is "Boot".
        
        var currentScene = SceneManager.GetActiveScene();
        
        // NOTE: Change "Boot" to whatever your actual Boot scene name is.
        // Assuming "Boot" for now based on context.
        if (currentScene.name == "Boot") 
        {
            return;
        }

        // If we are not in the Boot scene, we assume we started from a level/menu directly.
        Debug.Log($"[EditorBootStrapper] Detected start from '{currentScene.name}'. Redirecting to Boot...");
        
        TargetScene = currentScene.name;
        SceneManager.LoadScene("Boot");
    }
}
#endif

