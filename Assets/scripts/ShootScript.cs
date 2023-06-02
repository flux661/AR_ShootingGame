using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    public GameObject fire;
    public TMP_Text scoreTxt;
    public TMP_Text LifeTxt;
    public static int score;
    private int Life;
    public Image[] hearts;// make a array of hearts for max life

    void Start()
    {
        score = 0;
        Life = 3;

    }

    void Update ()
    {
        for(int i = 0;i<hearts.Length;i++) // we will run for max life(length of array)
        {
         
            if(i < Life)  // And enable hearts for 3 times (since life = 3)  
            {             // 0<3 enable; 1<3 enable;.. 3!<3 stop

                hearts[i].enabled = true;
            }
            else  // Or disable hearts , if after shooting bomb life reduce ,if life=2;
            {     // but for i=2 heart is enabled so disable it :)

                hearts[i].enabled = false;
            }
        }
    }


    public void Shoot()
    {

        RaycastHit hit;
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "BSS_Pumpkin_Orange_Funny(Clone)" || hit.transform.name == "Watermelon_512(Clone)" ||
                hit.transform.name == "Soccer Ball(Clone)" || hit.transform.name == "AtomRocket(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

                score++;
                scoreTxt.SetText("SCORE : " + score);
            }
            else if (hit.transform.name == "Mon_00(Clone)" || hit.transform.name == "Old-timer bomb prefab(Clone)" || hit.transform.name == "Bomb(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(fire, hit.point, Quaternion.LookRotation(hit.normal));

                score--;
                scoreTxt.SetText("SCORE : " + score);

                Life--;
                LifeTxt.SetText("LIFE : " + Life);

            }
            else if (hit.transform.name == "gem_13(Clone)" || hit.transform.name == "gem_08(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

                score = score + 2;

                scoreTxt.SetText("SCORE : " + score);
            }
            else if (hit.transform.name == "Heart(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

                Life++;
                LifeTxt.SetText( "LIFE : " + Life);
            }

        }
           if (Life == 0)
           {
             GameManager.Score = score;
             GameManager.isGameover = true;
             Time.timeScale = 0;

           }

    }

}
