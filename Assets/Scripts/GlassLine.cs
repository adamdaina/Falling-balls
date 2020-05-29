using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlassLine : MonoBehaviour
{
    //public int index_win;
    private int score = 0;
    public int highscore;
    private Text scoreText, highscoreText;
    public Animator transition;
    public GameObject NextLevelObject;

    void Awake()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        scoreText.text = "0";

        if (PlayerPrefs.HasKey("HighScore"))
        {
            highscore = PlayerPrefs.GetInt("HighScore");
            //highscoreText.text = highscore.ToString();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
     {
         GameObject hitObj = collision.gameObject;

         if (hitObj.tag == "Planet")
         {
            score++;
            scoreText.text = score.ToString();
            UpdateHighScore();

         }

          if (score == 13)
          {
            StartCoroutine(Next());
          }
     }

    public void UpdateHighScore()
    {
        if (score > highscore)
        {
            highscore = score;

            // there must be text command for highscore

            PlayerPrefs.SetInt("HighScore", highscore);

        }
    }

    IEnumerator Next()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        //transition.SetTrigger("Start");
        NextLevelObject.SetActive(true);
        //SceneManager.LoadScene(index_win);
    }

}