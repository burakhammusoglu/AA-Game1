using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public void gamePlay()
    {
        int registerLevel = PlayerPrefs.GetInt("registerLevel");
        if (registerLevel == 0)
        {
            SceneManager.LoadScene(registerLevel + 1);
        }
        else
        {
            SceneManager.LoadScene(registerLevel);
        }

    }
    public void gameQuit()
    {
        Application.Quit();
    }
    
}
