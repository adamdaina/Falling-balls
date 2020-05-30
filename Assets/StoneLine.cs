﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoneLine : MonoBehaviour
{
    //public int index_lose;
    public GameObject GameOverMenu;

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject hitObject = collision.gameObject;

        if (hitObject.tag == "Planet")
        {
            GameOverMenu.SetActive(true);
            
        }
   
    }

}
