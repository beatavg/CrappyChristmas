using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TreeScript : MonoBehaviour
{

    public GameObject Sphere;
    //public GameObject WhiteSmoke;

    private void OnTriggerEnter(Collider col)
    {
        //WhiteSmoke.SetActive(true);
        //Debug.Log("WhiteSmoke!");
        var lt = Sphere.GetComponent<Light>();
        lt.intensity = lt.intensity + 5F;
        //WhiteSmoke.SetActive(true);
        Debug.Log(lt.intensity);

        if (col.tag == "Shoe")
        {
            ProgressBar.CO2 += 100;
        }
        else if (col.tag == "Ball")
        {
            ProgressBar.CO2 += 60;
        }
        else if (col.tag == "Toy")
        {
            ProgressBar.CO2 += 50;
        }

    }
}