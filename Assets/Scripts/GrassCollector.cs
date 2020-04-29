using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrassCollector : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Planet")
        {
            Destroy(target.gameObject);
            SceneManager.LoadScene("LoseScene2");

        }

        if (target.tag == "SunBomb")
        {
            Destroy(target.gameObject);

        }
    }
}

