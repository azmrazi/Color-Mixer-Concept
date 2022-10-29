using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public int nums = 0;
    float camSens = 0.01f; 
    private Vector3 lastMouse = new Vector3(255, 255, 255);
    

    void Update()
    {
        MouseMove();
    }

    void MouseMove()
    {
        lastMouse = Input.mousePosition - lastMouse;
        lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0);
        lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
        transform.eulerAngles = lastMouse;
        lastMouse = Input.mousePosition;
        //Mouse  camera angle done.  

        //Keyboard commands
        Vector3 p = GetBaseInput();
        
        p = p * Time.deltaTime;
        Vector3 newPosition = transform.position;
    }

    private Vector3 GetBaseInput()
    { //returns the basic values, if it's 0 than it's not active.
        Vector3 p_Velocity = new Vector3();
        return p_Velocity;
    }

    void OnMouseDown()
    {
        Banana Object = GetComponent<Banana>();
        if(Object != null)
        {
            ++nums;
            Debug.Log(nums);
        }
    }
}
