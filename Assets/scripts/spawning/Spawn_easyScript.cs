using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_easyScript : MonoBehaviour
{
    public GameObject[] Objects;
    private int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawing());
    }


    IEnumerator StartSpawing()
    {

        yield return new WaitForSeconds(3);

        for (int i = 0; i < 3; i++)
        {

            Vector3 randomSpawnPosition = new Vector3(Random.Range(-1.5f, 1.5f), -0.5f, Random.Range(1.5f, 3f));  //We are creating random positions from
                                                                                                                  //-1.5 to 1.5 in X-axis and 1.5 to 3 in Z-axis


            System.Random rnd = new System.Random();// we are creating random numbers from 0 to 6
            int number = rnd.Next(0, 7);   // 0 is min. and 7 is max, but is counts from 0 to 6 and it neglects 6(max.) 


            Instantiate(Objects[number], randomSpawnPosition, Quaternion.identity);  //We will now assign our objects to random positions one by one
            num++;
            yield return new WaitForSeconds(2);


        }

        StartCoroutine(StartSpawing()); //We will recurssively call our StartSpawning function over and over

    }
}
