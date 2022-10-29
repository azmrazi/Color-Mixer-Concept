using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggPlant : MonoBehaviour
{
    public int eggplants = 0;

    void OnMouseDown()
    {
        ++eggplants;
    }
}
