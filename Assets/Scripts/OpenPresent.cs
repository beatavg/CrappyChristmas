using UnityEngine;
using System.Collections;

public class OpenPresent : MonoBehaviour
{   
    public GameObject contains;
    //public AudioSource Source;

    //void Awake(){
    	//Source = GetComponent<AudioSource>();
    //}

    void OnMouseDown(){
        Vector3 p = transform.position;
        this.gameObject.SetActive(false);
        contains.SetActive(true);

        //Source.Play();
        //Debug.Log("funkar");
  }

}
