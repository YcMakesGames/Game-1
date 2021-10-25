using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;

public class BirdJump : MonoBehaviour
    {
    
    public AudioSource Jumps, Death, Coin;
    public GameObject panel;
    public Text PointsText;
    public int Points;
    public GameObject yes;
    public Animator animator;
    public float JumpForce = 1;    
    public Rigidbody2D rb;
    void Start()
    {
        panel.SetActive(false);
    }

    void Update()
    {
        PointsText.text = Points.ToString();

        if(Input.GetKeyDown(KeyCode.Mouse0)){
            Jump();


        }
        foreach (Touch touch in Input.touches)
        {
            if(touch.phase == TouchPhase.Began){
            Jump();
            }
        }

    }
    // I could probs use a lambda expression for I forgor how to do it
    void Jump(){rb.AddForce(Vector3.up * JumpForce, ForceMode2D.Impulse); Jumps.Play();}
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Win"){
            Points++;
            Coin.Play();
            animator.SetTrigger("Got");
            StartCoroutine("Wait");

        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
            Death.Play();
            Die.hasdied = true;
            yes.SetActive(false);
            StartCoroutine("Wait");
            Destroy(gameObject);
            

        
    }
    IEnumerator Wait(){yield return new WaitForSeconds(1f);}

}
