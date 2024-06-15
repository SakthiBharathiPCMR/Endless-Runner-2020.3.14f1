using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject gpu,missileLarge;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMissileLarge());
        
        StartCoroutine(SpawnGpu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnMissileLarge()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3f,7f));
            Vector3 pos = new Vector3(Random.Range(10f,15f),Random.Range(-3.75f,-3.3f), 0f);
            Instantiate(missileLarge, pos, Quaternion.identity);
        }
    }
   
    IEnumerator SpawnGpu()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1f, 3f));
            Vector3 pos = new Vector3(Random.Range(10f, 15f), Random.Range(-1.7f, -3.7f), 0f);
            Instantiate(gpu, pos, Quaternion.identity);
        }
    }
}
