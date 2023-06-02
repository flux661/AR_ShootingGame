using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text HighTxt;
  

    void Start ()
    {
        HighTxt.text = "HighScore : " + PlayerPrefs.GetInt("highscore",0).ToString();
    }
  
    public void ExitGame ()
    {
        Application.Quit();
    }

    public void GameInstructions()
    {

        SceneManager.LoadScene("instructions");
    }

    public void PlayGame_easy()
    {
        SceneManager.LoadScene("ShootGame easy");

    }
    public void PlayGame_medium()
    {
        SceneManager.LoadScene("ShootGame medium");

    }
    public void PlayGame_hard()
    {
        SceneManager.LoadScene("ShootGame hard");

    }




}