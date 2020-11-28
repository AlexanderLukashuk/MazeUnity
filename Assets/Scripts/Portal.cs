using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Application.LoadLevel(Application.loadedLevel);
            SceneManager.LoadScene("Victory");
        }
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
