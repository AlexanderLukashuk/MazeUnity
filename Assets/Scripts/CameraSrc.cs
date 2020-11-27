using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSrc : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    void Start()
    {
        offset = new Vector3(1, 1.5f, 0);
    }

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
