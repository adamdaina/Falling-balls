using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Animator transition;
    public int sceneToContinue;
    public int highscore;
    private Text highscoreText;

    void Awake()
    {
        highscoreText = GameObject.Find("HighScoreText").GetComponent<Text>();

        if (PlayerPrefs.HasKey("HighScore"))
        {
            highscore = PlayerPrefs.GetInt("HighScore");
            highscoreText.text = highscore.ToString();
        }
    }

    public void PlayGame()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");

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
