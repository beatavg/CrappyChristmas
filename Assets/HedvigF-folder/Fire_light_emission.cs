using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_light_emission : MonoBehaviour
{
    // Interpolate light color between two colors back and forth
    float duration = 1.0f;
    //Color color0 = Color.red;
    //Color color1 = Color.blue;

    Light lt;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        float phi = Time.time / duration * 2 * Mathf.PI;
        float amplitude = Mathf.Cos(phi) * 80F + 80F;
        lt.intensity = amplitude;
    }
}