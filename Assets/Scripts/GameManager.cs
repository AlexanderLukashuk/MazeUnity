﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int result = 0;
    public GameObject portal;
    //public Text scoreText;
    
    public void AddCoin(int coin)
    {
        result += coin;
        //scoreText.text = result.ToString();
    }

    void Start()
    {
        portal.SetActive(false);
    }

    void Update()
    {
        if (result == 6)
            portal.SetActive(true);
    }
}
