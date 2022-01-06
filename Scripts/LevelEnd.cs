using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public void Next_Level()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("currentscene") + 1);
    }

    public void Retry()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("currentscene"));
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
