using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    float distance = 10;
    public GameObject fire;
    public GameObject smoke;
    public GameObject presentFirePrefab;
    // private GameObject newFire;
    private GameObject ImageTarget;
    private Vector3 startPos;
    public GameObject present;
    
    void Start()
    {
        //explosion = GameObject.Find("ImageTarget/FireBall Variant");
        
        ImageTarget = GameObject.Find("ImageTarget");
        Debug.Log(ImageTarget);
        startPos = transform.position;
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

    void OnTriggerEnter(Collider col)
    {
        fire.SetActive(true);
        //smoke.SetActive(true);
        this.gameObject.SetActive(false);
        Vector3 endPosition = this.gameObject.transform.position;
        this.gameObject.transform.position = startPos;

        GameObject clone = Instantiate(presentFirePrefab, endPosition, transform.rotation, ImageTarget.transform);
        int randomTimer = (int)Random.Range(1.0f, 4.0f);
        Destroy(clone, randomTimer);
        
        //clone.SetActive(true);
        //clone.transform.position = startPos;


        //Instantiate(explosion, transform.position, transform.rotation);
        //explosion.transform.parent = ImageTarget.transform;
        //explosion.transform.SetParent(ImageTarget.transform);
        //explosion.SetActive(true);

        //this.gameObject.SetActive(true);
    }


}
