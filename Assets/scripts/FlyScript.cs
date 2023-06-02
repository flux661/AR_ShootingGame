using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyScript : MonoBehaviour
{
    public  float speed=0.5f;
    void Start()
    {
        
    }
     
    // Update is called once per frame
    void Update()
    {
      

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("ShootGame hard"))
        {
            
            //Debug.Log("updated speed: " + speed);
            //Debug.Log("current score:" + ShootScript.score);
            speed = (speed + ((ShootScript.score / 5) * 0.04f));
            transform.Translate(Vector3.up * Time.deltaTime * speed );
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("ShootGame medium"))
        {
            
            //Debug.Log("updated speed: " + speed);
            speed = (speed + ((ShootScript.score / 5) * 0.02f));
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            

        }
        else
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        
    }
    
}
