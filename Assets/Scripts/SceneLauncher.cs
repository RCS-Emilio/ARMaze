using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLauncher : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadTheScene(string scene) { 
        SceneManager.LoadScene(scene);
    }

    public void DoExitGame() {
        Application.Quit();
    }
}
