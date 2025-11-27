using UnityEngine;
using Cysharp.Threading.Tasks;
using UnityEngine.SceneManagement;
using System;
using VContainer;
using VContainer.Unity;

public class RandomCube : MonoBehaviour
{
    void Start()
    {
        SpawnCube().Forget();
    }

    private async UniTaskVoid SpawnCube()
    {
        await UniTask.Delay(TimeSpan.FromSeconds(1));
        LoadScene();
    }

    private void LoadScene()
    {
        LifetimeScope.Find<RootLifetimeScope>().Container.Resolve<ISceneLoaderService>().LoadSceneAsync("HelloWorldScene").Forget();
    }
}