using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowValueScript : MonoBehaviour { 
    Text co2Text;

    // Start is called before the first frame update
    void Start()
    {
        co2Text = GetComponent<Text>();
    }

    // Update is called once per frame
    public void textUpdate (float value)
    {
        co2Text.text = Mathf.RoundToInt(value * 100) + "kg CO2";
    }
}
