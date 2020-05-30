using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Animator transition;
    public int sceneToContinue;
    public int highscore, lastscene, score;
    private Text highscoreText, leveltext, scoreText;

    void Awake()
    {
        highscoreText = GameObject.Find("HighScoreText").GetComponent<Text>();
        leveltext = GameObject.Find("LevelText").GetComponent<Text>();

        if (PlayerPrefs.HasKey("HighScore"))
        {
            highscore = PlayerPrefs.GetInt("HighScore");
            highscoreText.text = "BEST: " + highscore.ToString();
        }

        if (PlayerPrefs.HasKey("SavedScene"))
        {
            lastscene = PlayerPrefs.GetInt("SavedScene");
            leveltext.text = "LEVEL " + lastscene.ToString();
        }

        if (PlayerPrefs.HasKey("Score"))
        {
            score = PlayerPrefs.GetInt("Score");
            //scoreText.text = "Score: " + score.ToString();
        }
    }

    public void PlayGame()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");
        score = 0;
        PlayerPrefs.SetInt("Score", score);

        if (sceneToContinue != 0)
        {
            StartCoroutine(LoadLevel(sceneToContinue));
        }

        if (sceneToContinue == 0)
        {
            StartCoroutine(LoadLevel(sceneToContinue + 1));
        }

        //StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int sceneToContinue)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene(sceneToContinue);
    }
}
