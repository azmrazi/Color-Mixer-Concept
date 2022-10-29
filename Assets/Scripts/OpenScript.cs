using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class OpenScript : MonoBehaviour
{
    public StartMixing Start;
    public GameObject Fruit;

    void OnMouseDown()
    {
        if (Start.Loops == 1)
        {
            return;
        }
        OpenLid();
        FruitTrasform();

        /*var Banana = GameObject.FindWithTag("Banana");
        DOTween.Sequence()
            .Append(Banana.transform.DOMove(new Vector3(-0.261000007f, 1.37f, 4.15199995f), 1f, false))
            .Append(Banana.transform.DOMove(new Vector3(-0.252000004f, 1.24800003f, 4.22200012f), 1f, false));
        Banana.transform.DORotate(new Vector3(-84.7f, 0f, 0f), 1f, RotateMode.Fast);
        bananas++;*/

        //OtherBanana = ObjectSpawner.Instance.GetPooledObject();

    }

    
    void Update()
    {
        if (Start.Loops == 1)
        {

            //Fruit.transform.DOMove(new Vector3(-0.261999995f, 0.922999978f, 4.19799995f), 1f, false);
            Fruit.SetActive(false);
        }
    }

    void OpenLid()
    {
        var Lid = GameObject.FindWithTag("Lid");
        DOTween.Sequence()
            .Append(Lid.transform.DOMove(new Vector3(-0.0670000017f, 0.94957298f, 4.74700022f), 2f, false))
            .Append(Lid.transform.DOMove(new Vector3(-0.261000007f, 1.37f, 4.15199995f), 1f, false));
    }
    
    void FruitTrasform()
    {
        if (Fruit != null)
        {
            Fruit.SetActive(true);
            DOTween.Sequence()
                .Append(Fruit.transform.DOMove(new Vector3(-0.261000007f, 1.37f, 4.15199995f), 1f, false))
                .Append(Fruit.transform.DOMove(new Vector3(-0.252000004f, 1.24800003f, 4.22200012f), 1f, false));
            Fruit.transform.DORotate(new Vector3(-84.7f, 0f, 0f), 1f, RotateMode.Fast);


        }
    }
}
