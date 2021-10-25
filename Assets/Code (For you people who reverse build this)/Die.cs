using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Die : MonoBehaviour
{
    public static bool hasdied = false;
    public GameObject panel;
    void Awake()
    {
        panel.SetActive(false);
    }
    void Update()
    {
        if(hasdied){
            panel.SetActive(true);
            hasdied = false;
        }
    }
    public void Retry(){
        //I just.. Borrowed this code
        panel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
