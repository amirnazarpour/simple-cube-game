using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUi : MonoBehaviour
{
    public void BtnStart()
    {
        if (PlayerPrefs.GetInt("Level") == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
        }     
    }
    public void BtnHomw()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        int LevelNumber= SceneManager.GetActiveScene().buildIndex + 1;
        PlayerPrefs.SetInt("Level", LevelNumber);
    }
}
