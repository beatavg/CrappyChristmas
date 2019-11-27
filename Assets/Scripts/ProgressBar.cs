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
    public float maxCO2 = 100f;
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
        //IncrementProgress(0.75f);
        CO2 = minCO2;
    }

    private void Update()
    {
        slider.value = CO2 / maxCO2;
        slider.value += FillSpeed * Time.deltaTime;
        //slider.fillAmount = CO2 / minCO2;
    }
    // Update is called once per frame
    //void Update()
    //{
    //   if (slider.value < targetProgress)
    //  {
    //    slider.value += FillSpeed * Time.deltaTime;
    //  if (!particleSys.isPlaying)
    //    particleSys.Play();
    //}
    //else
    //{
    //  particleSys.Stop();
    //}

    //}

    //public void IncrementProgress(float newProgress)
    //{
    //    targetProgress = slider.value + newProgress;
    //}

}