using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text HighTxt;
   // public GameObject RulesPanel;

    void Start ()
    {
        HighTxt.text = "HighScore : " + PlayerPrefs.GetInt("highscore",0).ToString();
    }
    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   we can use this also
        SceneManager.LoadScene("ShootGame");

    }

    public void ExitGame ()
    {
        Application.Quit();
    }

    public void GameInstructions()
    {

        SceneManager.LoadScene("instructions");
    }

   /* public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }*/



}