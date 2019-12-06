using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowValueScript : MonoBehaviour { 
    Text co2Text;
    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        co2Text = GetComponent<Text>();
    }

    void Update()
    {
        showRestartWindow();
    }

    // Update is called once per frame
    public void textUpdate (float value)
    {
        co2Text.text = Mathf.RoundToInt(value * 100) + "kg CO2 released";
    }

    void showRestartWindow() {
        if ( GameObject.FindGameObjectsWithTag("Toy").Length == 0) 
        {
            if ( GameObject.FindGameObjectsWithTag("Ball").Length == 0) 
            {
                if ( GameObject.FindGameObjectsWithTag("Shoe").Length == 0)
                {
                    if ( GameObject.FindGameObjectsWithTag("Present").Length == 0)
                    {
                        GameOver.SetActive(true);
                    }
                }
            }
        }
    }
    
}
