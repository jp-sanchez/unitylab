using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pager : MonoBehaviour {

    private int currentSceneIndex;
    private int maxScenes;

    // Use this for initialization
    void Start () {

        //currentSceneIndex = int.Parse(sceneName.Substring("Scn_".Length,sceneName.Length));
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        maxScenes = SceneManager.sceneCountInBuildSettings;
    }
	

    public void onReleaseNext()
    {
        if(currentSceneIndex>= maxScenes-1)
        {
            currentSceneIndex = 0;

        }else
        {
            currentSceneIndex++;
        }
       
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void onReleaseBack()
    {
        if (currentSceneIndex <= 0 )
        {
            currentSceneIndex = maxScenes-1;

        }
        else
        {
            currentSceneIndex--;
        }
       
        SceneManager.LoadScene(currentSceneIndex);
    }
}
