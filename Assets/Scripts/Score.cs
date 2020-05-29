using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private int score = 0;
    private Text scoreText;

    void Awake()
    {
        scoreText = GameObject.Find ("Score").GetComponent<Text>();
        scoreText.text = "0";
    }

    /*
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Planet")
        {
            target.gameObject.SetActive(false);
            score++;
            scoreText.text = score.ToString();

            if (score == 13)
            {
                SceneManager.LoadScene("NextLevelScene");
            }

        }


    }*/
}
