using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;
    private ParticleSystem particleSys;

    public float FillSpeed = 0.5f;
    public float minCO2 = 1f;
    public float maxCO2 = 1000;
    //private float targetProgress = 0;
    public static float CO2;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        particleSys = GameObject.Find("Progress Bar Particles").GetComponent<ParticleSystem>();
    }


    // Start is called before the first frame update
    void Start()
    {
        CO2 = 0;
    }

    private void Update()
    {
        slider.value = CO2 / maxCO2;

        if (!particleSys.isPlaying)
        particleSys.Play();
   
    }

}