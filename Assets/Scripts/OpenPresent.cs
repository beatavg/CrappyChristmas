using UnityEngine;
using System.Collections;

public class OpenPresent : MonoBehaviour
{   
    public GameObject contains;
    private GameObject clone = null;

    void OnMouseDown(){
        Vector3 p = transform.position;
        this.gameObject.SetActive(false);
        contains.SetActive(true);
  }

  void Update() {
    
  }

}
