using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class SliderSettings : MonoBehaviour
{
    public Slider slider;
    public Volume globalVolume;
    float intensity;

    private ColorAdjustments colorAdjustments;

   // public Light2D globalLight;
    // Start is called before the first frame update
    void Start()
    { 
        slider.onValueChanged.AddListener(delegate { ChangeSlider(); });

        globalVolume.profile.TryGet(out colorAdjustments);
        colorAdjustments.postExposure.value = PlayerPrefs.GetFloat("Brightness");
        //intensity = globalLight.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(colorAdjustments.postExposure.value);
    }

    public void ChangeSlider()
    {
        //globalLight.intensity *= slider.value;
        PlayerPrefs.SetFloat("Brightness", slider.value);
        //globalLight.intensity = intensity * slider.value;
        colorAdjustments.postExposure.value = PlayerPrefs.GetFloat("Brightness");
            //GetComponent<ColorAdjustments>().postExposure.value = slider.value;
    }
}
