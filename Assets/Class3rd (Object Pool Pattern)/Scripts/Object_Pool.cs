using UnityEngine;
using System.Collections.Generic;

public class Object_Pool : Singleton<Object_Pool>
{
    [SerializeField] int PoolSize;

    Queue<GameObject> PoolQueue = new Queue<GameObject>();

    protected void Awake()
    {
        base.Awake();

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
