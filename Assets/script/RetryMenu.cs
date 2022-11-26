using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryMenu : MonoBehaviour
{
    public static bool GameIsEnd = false;
    public GameObject RetryMenuUI;
    public GameObject player;
    // Start is called before the first frame update



    public void Restart2()
    {
        //level 2
        Time.timeScale = 1f;
        SceneManager.LoadScene("level2");
        RetryMenuUI.SetActive(false);
        GameIsEnd = false;
        Time.timeScale=1f;

    }



    public void Restart1()
    {
        //level1
        Time.timeScale = 1f;
        SceneManager.LoadScene("level1");
        RetryMenuUI.SetActive(false);
        GameIsEnd = false;
        Time.timeScale=1f;

    }

    public void home()
    {   
        Time.timeScale = 1f;
        SceneManager.LoadScene("start_menu");
    }
}

