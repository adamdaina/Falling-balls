using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlassLine : MonoBehaviour
{
    public int index_win;
    private int score = 0;
    private Text scoreText;
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

         if (hitObj.tag == "Planet")
         {
            score++;
            scoreText.text = score.ToString();

         }

          if (score == 14)
          {
            StartCoroutine(Next());
          }
     }

    IEnumerator Next()
    {
        yield return new WaitForSecondsRealtime(2f);
        //transition.SetTrigger("Start");
        NextLevelObject.SetActive(true);
        //SceneManager.LoadScene(index_win);
    }

}