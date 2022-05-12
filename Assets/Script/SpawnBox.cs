using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    [SerializeField]
    private GameObject boxholder;

    void Start()
    {
        StartCoroutine(Spawner());
        
    }

    // Update is called once per frame
   IEnumerator Spawner()
    {
        
        yield return new WaitForSeconds(5);
        Instantiate(boxholder, transform.position, Quaternion.identity);
        StartCoroutine(Spawner());
       
    }
    
}
