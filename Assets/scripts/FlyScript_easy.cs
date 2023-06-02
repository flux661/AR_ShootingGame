using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript_easy : MonoBehaviour
{
    public float speed = 0.2f;
     
    // Update is called once per frame
    void Update()
    {

        if (ShootScript.score > 0 && ShootScript.score % 5 == 0)
        {
            speed += 0.3f;
        }
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
