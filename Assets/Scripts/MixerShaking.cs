using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MixerShaking : MonoBehaviour
{
    private int loops = 0;
    public StartMixing MixerType = null;
    public RayCastCamera Ray;

    void OnMouseDown()
    {
        if (loops == 1)
        {
            return;
            

        }
        else if(Ray.IsAboveZero())
        {
            var Mixer = GameObject.FindWithTag("Mixer");
            Mixer.transform.DORotate(new Vector3(0f, 87.7f, 1f), 0.15f, RotateMode.Fast).SetLoops(25, LoopType.Yoyo);
            ++loops;
        }
        
        
            
    }
}
