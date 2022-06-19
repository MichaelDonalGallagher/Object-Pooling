using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject weapon;
    void Start()
    {
        print("Start");
    }

    void OnMouseDown()
    {
        weapon = ObjectPooler.sharedInstance.GetPooledObject();
        if(weapon != null)
        {
            weapon.SetActive(true);
        }
        else
        {
            print("No More weapons left");
        }

        //ObjectPooler.sharedInstance.TesterMethod();
    }
}
