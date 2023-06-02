using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteScript : MonoBehaviour
{
    public void startdeleting()
    {
        StartCoroutine(destroy());
    }

    IEnumerator destroy()
    {
        yield return new WaitForSeconds(30);
        Object.Destroy(this.gameObject);
    }

}
