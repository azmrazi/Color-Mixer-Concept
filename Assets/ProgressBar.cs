using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;

    public float Velocity = 0;
    
    public void SetPercent(int percents)
    {
        float CurrentPercent = Mathf.SmoothDamp(slider.value, percents, ref Velocity, 100 * Time.deltaTime);
        slider.value = CurrentPercent;
    }


}
