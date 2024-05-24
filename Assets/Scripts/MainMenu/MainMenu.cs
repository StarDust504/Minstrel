using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    private void Start()
    {
        Debug.Log($"Screen width: {Screen.width}; screen height {Screen.height}");
    }

    public void ResetBrightnessScreen()
    {
        PlayerPrefs.SetInt("FirstLaunch", 0);
    }
}
