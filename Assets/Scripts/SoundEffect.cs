using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.Play();
    }


   // void onEnable(){
        
    //}
    //if (this.gameObject.activeSelf)
    //{
    //    source.Play();
    //}
}
