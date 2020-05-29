using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    private int currentSceneInd;
    public void MenuLoad()
    {
        currentSceneInd = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneInd);
        SceneManager.LoadScene("MainMenu");
    }
}