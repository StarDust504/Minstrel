using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class StartSettings : MonoBehaviour
{

    public GameObject brightnessCanvas;
    public GameObject mainMenu;
    public GameObject settings;

    public Volume globalVolume;
    private ColorAdjustments colorAdjustments;

    //public Light2D globalLight;
    // Start is called before the first frame update
    private void Awake()
    {
        //globalLight.intensity = 1.0f;
        //.SetFloat("Brightness", 0.0f);
    }
    void Start()
    {
        if (PlayerPrefs.GetInt("FirstLaunch") == 1)
        {
            brightnessCanvas.SetActive(false);
            mainMenu.SetActive(true);
            settings.SetActive(false);
        }
        else
        {
            brightnessCanvas.SetActive(true);
            mainMenu.SetActive(false);
            settings.SetActive(false);
        }
        globalVolume.profile.TryGet(out colorAdjustments);

        colorAdjustments.postExposure.value = PlayerPrefs.GetFloat("Brightness");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(colorAdjustments.postExposure.value);
        //Debug.Log(PlayerPrefs.GetInt("FirstLaunch"));
    }
}
