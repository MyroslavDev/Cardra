using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader
{
    private readonly MonoBehaviour _coroutineRunner;

    public SceneLoader(MonoBehaviour coroutineRunner)
    {
        _coroutineRunner = coroutineRunner;
    }

    public void Load(string sceneName, System.Action onLoaded = null)
    {
        _coroutineRunner.StartCoroutine(LoadSceneAsync(sceneName, onLoaded));
    }

    private IEnumerator LoadSceneAsync(string sceneName, System.Action onLoaded)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);
        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {
            if (asyncLoad.progress >= 0.9f)
                asyncLoad.allowSceneActivation = true;

            yield return null;
        }

        onLoaded?.Invoke();
    }
}