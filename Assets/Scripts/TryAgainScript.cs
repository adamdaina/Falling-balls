using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainScript : MonoBehaviour
{
    private int currentSceneInd;

    public void TryAgain()
    {
        currentSceneInd = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneInd);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
}
