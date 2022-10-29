using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.Pool;

public class ObjectSpawner : MonoBehaviour
{
    public static ObjectSpawner Instance;
    public GameObject Fruit;
    private List<GameObject> PooledObjects = new List<GameObject>();
    private int AmountToPool = 20;

    [SerializeField] private GameObject ObjectPrefab;

    private void Awake()
    {
       if (Instance == null)
        {
            Instance = this;
        }
    }
    
    void Start()
    {
        for (int i = 0; i < AmountToPool; i++)
        {
            GameObject Object = Instantiate(ObjectPrefab);
            Object.SetActive(false);
            PooledObjects.Add(Object);
        }
    }
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < PooledObjects.Count; i++)
        {
            if (!PooledObjects[i].activeInHierarchy)
            {
                return PooledObjects[i];
            }
        }
        return null;
    }

    void OnMouseDown()
    {
        Fruit = this.GetPooledObject();
        if (Fruit != null)
        {
            Fruit.SetActive(true);
        }
    }

}
