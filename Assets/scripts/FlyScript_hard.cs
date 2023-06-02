using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript_hard : MonoBehaviour
{
    public float speed = 0.5f;
     
    // Update is called once per frame
    void Update()
    {
        if (ShootScript.score > 0 && ShootScript.score % 5 == 0)
        {
            speed += 0.5f;
        }

            transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
