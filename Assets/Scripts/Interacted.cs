using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacted : MonoBehaviour
{
    private Outline outline;

    void Start()
    {
        outline = GetComponent<Outline>();

    }
    private void OnMouseEnter()
    {
        outline.enabled = true;
    }
    private void OnMouseExit()
    {
        outline.enabled = false;
    }
}
