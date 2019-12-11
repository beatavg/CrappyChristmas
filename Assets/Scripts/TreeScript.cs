using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TreeScript : MonoBehaviour
{

    public GameObject Sphere;
    public GameObject WhiteSmoke;
    public GameObject Sphere_directional;

    private void OnTriggerEnter(Collider col)
    {
        WhiteSmoke.SetActive(true);
        //Debug.Log("WhiteSmoke!");
        var lt = Sphere.GetComponent<Light>();
        lt.intensity = lt.intensity + 5F;

        var lt2 = Sphere_directional.GetComponent<Light>();
        lt2.intensity = 4F;
        
            WhiteSmoke.SetActive(true);
        //Debug.Log("Light intensifies!");

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