using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed;

    void Update()
    {
       transform.Translate(Vector3.left * speed); 
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Destroy"){
            Destroy(gameObject);
            //Note from dev: This is to improve gameplay cuz if you dont get rid of pipes then they will just consume

        }
    }
}
