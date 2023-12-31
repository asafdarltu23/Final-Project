using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Update is called once per frame
    public void Exit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }

    public void NextLevel()
    {
        if (PlayerPrefs.GetFloat("Completes") == 1)
            SceneManager.LoadScene("LevelSecond");
        if (PlayerPrefs.GetFloat("Completes") == 2)
            SceneManager.LoadScene("EndScreen");
    }

    public void Reload()
    {
        SceneManager.LoadScene(Death.currentLevel);
    }
}
