using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlassLine_2 : MonoBehaviour
{
    private int privatscore = 0;
    public int score, highscore, score2;
    private Text scoreText, highscoreText;

    public Animator transition;
    public GameObject NextLevelObject;

    void Awake()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();

        if (PlayerPrefs.HasKey("HighScore"))
        {
            highscore = PlayerPrefs.GetInt("HighScore");
            //highscoreText.text = highscore.ToString();
        }

        if (PlayerPrefs.HasKey("Score"))
        {
            score = PlayerPrefs.GetInt("Score");

        }

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
            privatscore++;
            score++;
            UpdateHighScore();
            scoreText.text = "Score: " + score.ToString();
        }

        if (privatscore + score2 == 13)
        {
            StartCoroutine(Next());
        }


    }

    public void UpdateHighScore()
    {
        PlayerPrefs.SetInt("Score", score);

        if (score > highscore)
        {
            highscore = score;

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