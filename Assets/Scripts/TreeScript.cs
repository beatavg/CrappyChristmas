using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TreeScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Shoe")
        {
            ProgressBar.CO2 += 10f;
            Debug.Log("skooor");
        }
        else if (col.tag == "Ball")
        {
            ProgressBar.CO2 += 30f;
            Debug.Log("Baaall");
        }
        else if (col.tag == "Toy")
        {
            ProgressBar.CO2 += 40f;
            Debug.Log("Toy");
        }

    }
}
