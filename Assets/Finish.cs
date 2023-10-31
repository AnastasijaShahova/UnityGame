using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "overpass_middle002")
        {
            SceneManager.LoadScene("End Screen");
        }
    }
}