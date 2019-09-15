using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValuesScript : MonoBehaviour
{
    public Slider RotatorSlider;
    public Slider PinSlider;
    public Text RotatorText;
    public Text PinText;

    public static float RotatorSpeed = 150;
    public static float PinSpeed = 150;

    void Update()
    {
        RotatorText.text = RotatorSlider.value.ToString("f2");
        PinText.text = PinSlider.value.ToString("f2");
        RotatorSpeed = RotatorSlider.value;
        PinSpeed = PinSlider.value;
    }
}
