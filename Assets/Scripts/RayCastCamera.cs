using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastCamera : MonoBehaviour
{
    Camera cam;
    
    public int[] Fruits = new int[7];
    
    void Start()
    {
        cam = this.GetComponent<Camera>();
    }

    
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 100f;
        mousePos = cam.ScreenToWorldPoint(mousePos);
        Debug.DrawRay(transform.position, mousePos - transform.position, Color.blue);

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100))
            {


                switch(hit.transform.tag)
                {
                    case "Banana":
                        ++Fruits[0];
                        break;
                    case "Orange":
                        ++Fruits[1];
                        break;
                    case "Apple":
                        ++Fruits[2];
                        break;
                    case "Tomato":
                        ++Fruits[3];
                        break;
                    case "Eggplant":
                        ++Fruits[4];
                        break;
                    case "Pear":
                        ++Fruits[5];
                        break;
                    case "Cherries":
                        ++Fruits[6];
                        break;
                }



            }
            
        }
    }
    public bool IsAboveZero()
    {
        foreach(int value in Fruits)
        {
            if (value >= 1)
            {
                return true;
            }
            
        }
        return false;
    }
}