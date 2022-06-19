using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKunai : MonoBehaviour
{
    public float speed = 2;

    private void Start()
    {
        Invoke("DestroyMe", 2);
    }
    void Update()
    {
        this.transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    void DestroyMe()
    {
        print("Destryo Invoked");
        Destroy(this.gameObject);
    }
}
