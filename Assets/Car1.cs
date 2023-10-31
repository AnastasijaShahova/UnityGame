using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car1 : MonoBehaviour
{
    float points = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "check")
        {
            points++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "aaa" & points == 9)
        {
            Application.LoadLevel("EndScreen");
        }

        if (other.gameObject.tag == "aaa" & points < 9)
        {
            Application.LoadLevel("Lose Screen");
        }
    }

    public void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 250, 50), "Чекпоинтов: " + points + " /9");
    }
}