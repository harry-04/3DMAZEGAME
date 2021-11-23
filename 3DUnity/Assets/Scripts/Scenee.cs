using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenee : MonoBehaviour
{
    public void LevelOne()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
