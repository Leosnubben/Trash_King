using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void PlayEasy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PlayMedium()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void PlayHard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
    public void Quitgame()
    {
        Application.Quit();
    }
}
