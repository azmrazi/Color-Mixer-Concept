using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : MonoBehaviour
{
    public int tomatoes = 0;

    void OnMouseDown()
    {
        ++tomatoes;
    }
}
