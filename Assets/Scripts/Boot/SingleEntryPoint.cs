using UnityEngine;
using Cysharp.Threading.Tasks;
using VContainer;
using VContainer.Unity;

public sealed class SingleEntryPoint : IStartable
{
    readonly AppBootstrapper bootstrapper;
    readonly ISceneLoaderService sceneLoaderService;
    readonly LifetimeScope rootLifetimeScope;
    readonly LifetimeScopePrefabs lifetimeScopePrefabs;

    [Inject]
    public SingleEntryPoint(
            AppBootstrapper bootstrapper,
            ISceneLoaderService sceneLoaderService,
            LifetimeScope rootLifetimeScope,
            LifetimeScopePrefabs lifetimeScopePrefabs
        )
    {
        this.lifetimeScopePrefabs = lifetimeScopePrefabs;
        this.rootLifetimeScope = rootLifetimeScope;
        this.sceneLoaderService = sceneLoaderService;
        this.bootstrapper = bootstrapper;
    }

    void IStartable.Start()
    {
        RunBootSequence().Forget();
    }

    private async UniTaskVoid RunBootSequence()
    {
        LifetimeScope bootLifetimeScope = rootLifetimeScope.CreateChildFromPrefab
            (lifetimeScopePrefabs.bootLiftimeScopePrefab.GetComponent<BootLifetimeScope>());

        Debug.Log("BootLifetimeScope created");

        await bootstrapper.BootAsync();

        bootLifetimeScope.Dispose();
        Debug.Log("BootLifetimeScope disposed");

        string targetScene = "MainMenu"; // Default scene

#if UNITY_EDITOR
        if (!string.IsNullOrEmpty(EditorBootStrapper.TargetScene))
        {
            targetScene = EditorBootStrapper.TargetScene;
            Debug.Log($"[SingleEntryPoint] Redirecting to original target: {targetScene}");
        }
#endif

        await sceneLoaderService.LoadSceneAsync(targetScene);
    }
}
