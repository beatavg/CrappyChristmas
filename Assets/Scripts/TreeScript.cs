﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TreeScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
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