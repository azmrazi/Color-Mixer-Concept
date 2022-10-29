using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class MoveScriptForApple : MonoBehaviour
{
    public StartMixing Start;

 
    public GameObject Fruit;

    void OnMouseDown()
    {
        
        if (Start.Loops == 1)
        {
            return;
        }
        var Lid = GameObject.FindWithTag("Lid");
        DOTween.Sequence()
            .Append(Lid.transform.DOMove(new Vector3(-0.0670000017f, 0.94957298f, 4.74700022f), 2f, false))
            .Append(Lid.transform.DOMove(new Vector3(-0.261000007f, 1.37f, 4.15199995f), 1f, false));

        
        //Fruit = ObjectSpawner.Instance.GetPooledObject();
        if (Fruit != null)
        {
            Fruit.SetActive(true);
            DOTween.Sequence()
                .Append(Fruit.transform.DOMove(new Vector3(-0.261000007f, 1.37f, 4.15199995f), 1f, false))
                .Append(Fruit.transform.DOMove(new Vector3(-0.26730001f, 1.17499995f, 4.12900019f), 1f, false));
            

        }

       

    }

    void Update()
    {
        if (Start.Loops == 1)
        {

            //Fruit.transform.DOMove(new Vector3(-0.261999995f, 0.922999978f, 4.19799995f), 1f, false);
            Fruit.SetActive(false);
        }
    }
}
