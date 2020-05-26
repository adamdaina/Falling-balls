using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlassLine_2 : MonoBehaviour
{
    private int score = 0;
    public GameObject glass_2;
    private int score2 = 0;
    private Text scoreText;
    private int scoresum;
    public Animator transition;
    public GameObject NextLevelObject;

    void Awake()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        scoreText.text = "0";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject hitObj = collision.gameObject;
        scoresum = score + score2;

        if (hitObj.tag == "Planet")
        {
            score++;
            scoreText.text = score.ToString();

        }

        if (hitObj.tag == "Planet")
        {
            score2++;
        }

        if (scoresum == 13)
        {
            StartCoroutine(Next());
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