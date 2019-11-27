using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        ProgressBar.CO2 += 10f;    
    }
}
