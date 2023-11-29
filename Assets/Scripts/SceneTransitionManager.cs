/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManger : MonoBehaviour
{
    public FadeScreen fadeScreen;
    public static bool adult;
    
    public void GoToSceneAsync(int sceneIndex)
    {
        StartCoroutine(GoToSceneAsyncRoutine(sceneIndex));
    }
    
    IEnumerator GoToSceneAsyncRoutine(int sceneIndex)
    {
        //fadeScreen.FadeOut();
        //Launch the new scene
        AsyncOperation operation = null;

        if(adult && sceneIndex == 3)
        {
            operation = SceneManager.LoadSceneAsync(11);
        }
        else
        {
            operation = SceneManager.LoadSceneAsync(sceneIndex);
        }

        operation.allowSceneActivation = false;

        float timer = 0;
        while (timer <= fadeScreen.fadeDuration && !operation.isDone)
        {
            timer += Time.deltaTime;
            yield return null;
        }
        operation.allowSceneActivation = true;
    }

    public void adultBoolTrue()
    {
        adult = true;
    }

    public void adultBoolFalse()
    {
        adult = false;
    }
}*/