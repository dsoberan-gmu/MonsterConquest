using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Press the start button to play the game.
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Press the quit button to exit out of the app.
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
