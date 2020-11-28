using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Triggers : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Application.LoadLevel(Application.loadedLevel);
            SceneManager.LoadScene("GameOver");
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
