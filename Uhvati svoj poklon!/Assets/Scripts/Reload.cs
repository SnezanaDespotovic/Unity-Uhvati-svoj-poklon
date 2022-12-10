using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
 
    public GameObject deathMenuUI;
 
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
 
    public void Restart()
    {
        SceneManager.UnloadSceneAsync("game");
        SceneManager.LoadSceneAsync("menu");
    }
}