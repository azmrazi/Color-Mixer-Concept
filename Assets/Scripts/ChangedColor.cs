using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ChangedColor : MonoBehaviour
{
    MeshRenderer m_Renderer;
    public Color m_clear, m_first, m_second, m_third, m_bananas, m_apples, m_eggplant, m_tomato, m_orange, m_cherries, m_pear;
    public StartMixing Mixer = null;
    public RayCastCamera Ray;
    public Color TargetColor;
    public Color RandomColor;
    
    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
        m_Renderer.material.color = m_clear;
        TargetColor = m_clear;
        RandomColor = Random.ColorHSV();

    }

    // Update is called once per frame
    void Update()
    {
        if (Mixer == null) return;
        if(Mixer.Loops == 1 && Ray.Fruits[0] == 0 && Ray.Fruits[2] == 0 && Ray.Fruits[3] == 0 && Ray.Fruits[1] == 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] == 0 && Ray.Fruits[4] > 0)
        {
            TargetColor = m_eggplant;
        }
        else if (Mixer.Loops == 1 && Ray.Fruits[0] == 0 && Ray.Fruits[2] == 0 && Ray.Fruits[3] == 0 && Ray.Fruits[1] == 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] > 0 && Ray.Fruits[4] == 0)
        {
            TargetColor = m_pear;
        }
        else if (Mixer.Loops == 1 && Ray.Fruits[0] == 0 && Ray.Fruits[2] == 0 && Ray.Fruits[3] == 0 && Ray.Fruits[1] == 0 && Ray.Fruits[6] > 0 && Ray.Fruits[5] == 0 && Ray.Fruits[4] == 0)
        {
            TargetColor = m_cherries;
        }
        else if (Mixer.Loops == 1 && Ray.Fruits[0] == 0 && Ray.Fruits[2] == 0 && Ray.Fruits[3] == 0 && Ray.Fruits[1] > 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] == 0 && Ray.Fruits[4] == 0)
        {
            TargetColor = m_orange;
        }
        else if (Mixer.Loops == 1 && Ray.Fruits[0] == 0 && Ray.Fruits[2] == 0 && Ray.Fruits[3] > 0 && Ray.Fruits[1] == 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] == 0 && Ray.Fruits[4] == 0)
        {
            TargetColor = m_tomato;
        }
        else if (Mixer.Loops == 1 && Ray.Fruits[0] == 0 && Ray.Fruits[2] > 0 && Ray.Fruits[3] == 0 && Ray.Fruits[1] == 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] == 0 && Ray.Fruits[4] == 0)
        {
            TargetColor = m_apples;
        }
        else if (Mixer.Loops == 1 && Ray.Fruits[0] > 0 && Ray.Fruits[2] == 0 && Ray.Fruits[3] == 0 && Ray.Fruits[1] == 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] == 0 && Ray.Fruits[4] == 0)
        {
            TargetColor = m_bananas;
        }
        else if (Mixer.Loops == 1 && Ray.Fruits[0] == 1 && Ray.Fruits[2] == 1 && Ray.Fruits[3] == 0 && Ray.Fruits[1] == 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] == 0 && Ray.Fruits[4] == 0)
        {
            TargetColor = m_first;
        }
        else if (Mixer.Loops == 1 && Ray.Fruits[0] == 0 && Ray.Fruits[2] == 1 && Ray.Fruits[3] == 0 && Ray.Fruits[1] == 1 && Ray.Fruits[6] == 1 && Ray.Fruits[5] == 0 && Ray.Fruits[4] == 0)
        {
            TargetColor = m_second;
        }
        else if (Mixer.Loops == 1 && Ray.Fruits[0] == 0 && Ray.Fruits[2] == 0 && Ray.Fruits[3] == 1 && Ray.Fruits[1] == 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] == 1 && Ray.Fruits[4] == 1)
        {
            TargetColor = m_third;
        }
        else if(Mixer.Loops == 1 && ((Ray.Fruits[0] > 0 && Ray.IsAboveZero()) || (Ray.Fruits[1] > 0 && Ray.IsAboveZero()) || (Ray.Fruits[2] > 0 && Ray.IsAboveZero()) || (Ray.Fruits[3] > 0 && Ray.IsAboveZero()) || (Ray.Fruits[4] > 0 && Ray.IsAboveZero()) || (Ray.Fruits[5] > 0 && Ray.IsAboveZero()) || (Ray.Fruits[6] > 0 && Ray.IsAboveZero())))
        {
            TargetColor = RandomColor;
        }
        m_Renderer.material.color = Color.Lerp(m_Renderer.material.color, TargetColor, 0.03f);
    }

   
}
