using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiperSpawner : MonoBehaviour
{   
    bool isSpawning = false;
    public GameObject PipePrefab;
    public float MaxHeight = 2f;
    public float MinHeight = -3f;

    
    void Update()
    {
        
                
        if(isSpawning){
            return;

        }else{
            StartCoroutine("Spawn");
            
        }


    }
    IEnumerator Spawn(){
        isSpawning = true;
        yield return new WaitForSeconds(2f);
        Instantiate(PipePrefab, new Vector3(transform.position.x, Random.Range(MinHeight, MaxHeight), 0), Quaternion.identity);//bruh
        isSpawning = false;

    }


}
