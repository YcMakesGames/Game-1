using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SomeShit : MonoBehaviour
{
    public void Buttones(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }


}
