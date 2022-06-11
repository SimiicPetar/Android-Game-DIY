using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuickLoadScene : MonoBehaviour
{
    public string sceneToLoadName;
    public float timeToWaitBeforeLoadingScene = 0.1f;

    IEnumerator Start()
        {
            yield return new WaitForSeconds(timeToWaitBeforeLoadingScene);

            if (!string.IsNullOrEmpty(sceneToLoadName))
            {
                SceneManager.LoadScene(sceneToLoadName, LoadSceneMode.Single);
            }
        }
}
