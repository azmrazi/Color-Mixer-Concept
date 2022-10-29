using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherries : MonoBehaviour
{
    public int cherries = 0;

    void OnMouseDown()
    {
        ++cherries;
    }
}
