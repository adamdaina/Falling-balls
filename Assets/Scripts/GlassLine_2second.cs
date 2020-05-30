using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlassLine_2second : MonoBehaviour
{
    public int score2;

    void Awake()
    {
        if (PlayerPrefs.HasKey("Score2"))
        {
            score2 = PlayerPrefs.GetInt("Score2");

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject hitObj = collision.gameObject;

        if (hitObj.tag == "Planet")
        {           
            score2++;
            PlayerPrefs.SetInt("Score2", score2);
        }

    }
}
