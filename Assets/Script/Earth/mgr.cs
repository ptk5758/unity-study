using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mgr : MonoBehaviour
{
    [SerializeField]
    InputField inputField; // float
    [SerializeField]
    Slider slider; // float

    public void Save()
    {
        PlayerPrefs.SetString("StringA", inputField.text);
        PlayerPrefs.SetFloat("SliderA", slider.value);
    }
    public void Load()
    {
        inputField.text = PlayerPrefs.GetString("StringA");
        slider.value = PlayerPrefs.GetFloat("SliderA");
    }
}
