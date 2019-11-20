using UnityEngine;
using System.Collections;

public class OpenPresent : MonoBehaviour
{   
    public GameObject contains;

    void OnMouseDown(){
        Vector3 p = transform.position;
        this.gameObject.SetActive(false);
        contains.SetActive(true);
  }

}
