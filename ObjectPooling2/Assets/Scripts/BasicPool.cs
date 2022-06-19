using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPool : MonoBehaviour
{
    [SerializeField]
    public GameObject prefab;
    // need a private Queue here. Initally empty.
    public Queue<GameObject> queue = new Queue<GameObject>();
    public static BasicPool poolInstance;
    void Awake()
    {
        poolInstance = this;
        GrowPool();
    }
    //Loop 10? times and add newly instantiated objects to the pool
    private void GrowPool()
    {
        for (int j = 0; j < 10; j++)
        {
            AddToPool(prefab);
        }
    }
    //Make sure instance is not active
    //add to queue - enqueue
    public void AddToPool(GameObject instance)
    {
        queue.Enqueue(Instantiate(instance));
        instance.SetActive(false);
    }
    //Check if there are available objects (grow if required)
    //return an active instance using the FIFO queue
    public GameObject GetObjectFromPool()
    {
        if (queue.Count == 0)
            GrowPool();
        queue.Peek().SetActive(true);
        return queue.Dequeue();
    }

}
