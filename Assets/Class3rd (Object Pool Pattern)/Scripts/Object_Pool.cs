using UnityEngine;
using System.Collections.Generic;

public class Object_Pool : MonoBehaviour
{

    [SerializeField] int PoolSize;

    public static Object_Pool Instance;

    Queue<GameObject> PoolQueue = new Queue<GameObject>();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        CreatePool();
    }

    void CreatePool()
    {
        for (int i = 0; i < PoolSize; i++)
        {
            GameObject Object = Instantiate(Resources.Load<GameObject>("Minotaur"));

            Object.transform.SetParent(transform);

            Object.SetActive(false);

            PoolQueue.Enqueue(Object);
        }
    }

    public void ReturnObject(GameObject Object)
    {
        Object.SetActive(false);
        PoolQueue.Enqueue(Object);
    }

    public GameObject GetObject()
    {
        if (PoolQueue.Count > 0)
        {
            GameObject Object = PoolQueue.Dequeue();

            Object.SetActive(true);

            return Object;
        }

        GameObject NewObject = Instantiate(Resources.Load<GameObject>("Minotaur"));

        NewObject.transform.SetParent(transform);

        NewObject.SetActive(false);

        return NewObject;
    }
}
