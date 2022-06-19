using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningScript : MonoBehaviour
{
    public float delay = 1f;
    public GameObject objectToSpawn;
    public Vector3 spawnRange;

    private void Start()
    {
        spawnRange = new Vector3(transform.localScale.x, transform.localScale.y
, transform.localScale.z);
        StartCoroutine(SpawnSphere());
    }
    IEnumerator SpawnSphere()
    {
        yield return new WaitForSeconds(delay);
        Instantiate(objectToSpawn, new Vector3(Random.Range(-10, 10), Random.Range(0, 10), Random.Range(transform.position.z - transform.localScale.z, transform.position.z + transform.localScale.z)), Quaternion.identity);
    }
}
