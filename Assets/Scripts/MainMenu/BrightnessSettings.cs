using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class BrightnessSettings : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject brightnessCanvas;
    public GameObject mainMenu;
    public GameObject settings;

    private void Awake()
    {
        PlayerPrefs.SetFloat("Brightness", 0.0f);
    }
    private void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PlayerPrefs.GetInt("FirstLaunch"));
    }

    public void SetGameLaunchedOnce()
    {
        PlayerPrefs.SetInt("FirstLaunch", 1);
        brightnessCanvas.SetActive(false);
        mainMenu.SetActive(true);
    }
}
