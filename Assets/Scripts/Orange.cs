using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour
{
    public int oranges = 0;

    void OnMouseDown()
    {
        ++oranges;
    }
}
