using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pear : MonoBehaviour
{
    public int pears = 0;

    void OnMouseDown()
    {
        ++pears;
    }
}
