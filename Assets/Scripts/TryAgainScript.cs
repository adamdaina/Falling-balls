using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TryAgainScript : MonoBehaviour
{
    private int currentSceneInd;
    public int score;
    private Text scoreText;

    void Awake()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();

        if (PlayerPrefs.HasKey("Score"))
        {
            score = PlayerPrefs.GetInt("Score");
            scoreText.text = "Score: " + score.ToString();
        }
    }

    public void TryAgain()
    {
        RestScore();
        currentSceneInd = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneInd);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void RestScore()
    {
        score = 0;
        PlayerPrefs.SetInt("Score", score);
    }
}
