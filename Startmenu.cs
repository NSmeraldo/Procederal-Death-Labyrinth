using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startmenu : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject difficultyscreen;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Difficulty()
    {
        mainmenu.SetActive(false);
        difficultyscreen.SetActive(true);
    }
    public void Exitdifficulty()
    {
        mainmenu.SetActive(true);
        difficultyscreen.SetActive(false);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}