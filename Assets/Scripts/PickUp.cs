using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    float distance = 10;
    public GameObject fire;
    public GameObject explosion;
    // private GameObject newFire;
    private GameObject ImageTarget;
    void Start()
    {
        //explosion = GameObject.Find("ImageTarget/FireBall Variant");
        
        ImageTarget = GameObject.Find("ImageTarget");
        Debug.Log(ImageTarget);
    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;
    }
    void OnMouseUp() {
        ThrowBall();
    }

    void ThrowBall()
    {
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().AddForce(0f, 0f, 10000f); 
        
    }

    void OnCollisionEnter()
    {
        fire.SetActive(true);
        Destroy(this.gameObject);
        Instantiate(explosion, transform.position, transform.rotation);
        explosion.transform.parent = ImageTarget.transform;
        //explosion.transform.SetParent(ImageTarget.transform);
        explosion.SetActive(true);
 
    }


}
