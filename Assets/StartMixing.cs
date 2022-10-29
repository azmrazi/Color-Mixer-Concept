using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class StartMixing : MonoBehaviour
{

    private int loops = 0;
    public MoveScriptForApple Opens_1 = null;
    public RayCastCamera Ray;


    void OnMouseDown()
    {
        if (loops == 1)
        {
            return;
        }
        else if (Ray.Fruits[0] == 0 && Ray.Fruits[2] == 0 && Ray.Fruits[3] == 0 && Ray.Fruits[1] == 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] == 0 && Ray.Fruits[4] > 0)
        {
            CylinderTransform();
        }
        else if (Ray.Fruits[0] == 0 && Ray.Fruits[2] == 0 && Ray.Fruits[3] == 0 && Ray.Fruits[1] == 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] > 0 && Ray.Fruits[4] == 0)
        {
            CylinderTransform();
        }
        else if (Ray.Fruits[0] == 0 && Ray.Fruits[2] == 0 && Ray.Fruits[3] == 0 && Ray.Fruits[1] == 0 && Ray.Fruits[6] > 0 && Ray.Fruits[5] == 0 && Ray.Fruits[4] == 0)
        {
            CylinderTransform();
        }
        else if (Ray.Fruits[0] == 0 && Ray.Fruits[2] == 0 && Ray.Fruits[3] == 0 && Ray.Fruits[1] > 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] == 0 && Ray.Fruits[4] == 0)
        {
            CylinderTransform();
        }
        else if (Ray.Fruits[0] == 0 && Ray.Fruits[2] == 0 && Ray.Fruits[3] > 0 && Ray.Fruits[1] == 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] == 0 && Ray.Fruits[4] == 0)
        {
            CylinderTransform();
        }
        else if (Ray.Fruits[0] == 0 && Ray.Fruits[2] > 0 && Ray.Fruits[3] == 0 && Ray.Fruits[1] == 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] == 0 && Ray.Fruits[4] == 0)
        {
            CylinderTransform();
        }
        else if (Ray.Fruits[0] > 0 && Ray.Fruits[2] == 0 && Ray.Fruits[3] == 0 && Ray.Fruits[1] == 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] == 0 && Ray.Fruits[4] == 0)
        {
            CylinderTransform();
        }
        else if (Ray.Fruits[0] == 1 && Ray.Fruits[2] == 1 && Ray.Fruits[3] == 0 && Ray.Fruits[1] == 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] == 0 && Ray.Fruits[4] == 0)
        {
            CylinderTransform();
        }
        else if (Ray.Fruits[0] == 0 && Ray.Fruits[2] == 1 && Ray.Fruits[3] == 0 && Ray.Fruits[1] == 1 && Ray.Fruits[6] == 1 && Ray.Fruits[5] == 0 && Ray.Fruits[4] == 0)
        {
            CylinderTransform();
        }
        else if (Ray.Fruits[0] == 0 && Ray.Fruits[2] == 0 && Ray.Fruits[3] == 1 && Ray.Fruits[1] == 0 && Ray.Fruits[6] == 0 && Ray.Fruits[5] == 1 && Ray.Fruits[4] == 1)
        {
            CylinderTransform();
        }
        else if ((Ray.Fruits[0] > 0 && Ray.IsAboveZero()) || (Ray.Fruits[1] > 0 && Ray.IsAboveZero()) || (Ray.Fruits[2] > 0 && Ray.IsAboveZero()) || (Ray.Fruits[3] > 0 && Ray.IsAboveZero()) || (Ray.Fruits[4] > 0 && Ray.IsAboveZero()) || (Ray.Fruits[5] > 0 && Ray.IsAboveZero()) || (Ray.Fruits[6] > 0 && Ray.IsAboveZero()))
        {
            CylinderTransform();
        }
        else
        {
            return;
        }



    }

    public int Loops
    {
        get
        {
            return loops;
        }
    }

    void CylinderTransform()
    {
        var Cylinder = GameObject.FindWithTag("InnerCylinder");
        Cylinder.transform.DOScaleY(0.25f, 2f);
        Cylinder.transform.DORotate(new Vector3(0f, 0f, 180f), 0.15f, RotateMode.FastBeyond360).SetLoops(25, LoopType.Restart);
        loops++;
    }
}
