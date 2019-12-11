using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    float distance = 10;
    public GameObject fire;
    public GameObject smoke;
    public GameObject presentFirePrefab;
    public GameObject heat;
    public GameObject heatPrefab;
    // private GameObject newFire;
    private GameObject ImageTarget;
    private Vector3 startPos;
    public GameObject present;
    private int burnedPresents;
    
    void Start()
    {
        //explosion = GameObject.Find("ImageTarget/FireBall Variant");
        
        ImageTarget = GameObject.Find("ImageTarget");
        Debug.Log(ImageTarget);
        startPos = transform.position;
        burnedPresents = 0;
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
        //Activate tree fire and activate smoke
        fire.SetActive(true);
        smoke.SetActive(true);
        ++burnedPresents;
        if (burnedPresents == 1)
        {
            heat.SetActive(true);
            Debug.Log("heat " + burnedPresents);
        }
        else if(burnedPresents >= 1)
        {
            heat.transform.localScale += new Vector3(0f, 1f, 0f);
            Debug.Log("else " + burnedPresents);
        }

        //Deactivate present and store position
        this.gameObject.SetActive(false);
        Vector3 endPosition = this.gameObject.transform.position;
        this.gameObject.transform.position = startPos;

        // Create present effects (fire, heat distortion) disappear
        GameObject fireClone = Instantiate(presentFirePrefab, endPosition, transform.rotation, ImageTarget.transform);
        GameObject heatClone = Instantiate(heatPrefab, endPosition, transform.rotation, ImageTarget.transform);
        //Debug.Log(heatClone.transform.localRotation);
        
        heatClone.transform.localScale = new Vector3(0.5f, 2f, 0.5f);
        //heatClone.transform.localRotation = fireClone.transform.localRotation;
        //heatClone.transform.localRotation = new Quaternion(heatClone.transform.localRotation.x, heatClone.transform.localRotation.y, -360f);
        //heatClone.transform.Rotate = (0f, 0f, 0f, Self.World);
            //= (0, 0, -360);

        // Make those present effects disappear
        //GameObject clone = Instantiate(presentFirePrefab, endPosition, transform.rotation, ImageTarget.transform);
        int randomTimer = (int)Random.Range(1.0f, 4.0f);
        Destroy(fireClone, randomTimer);
        Destroy(heatClone, randomTimer);

    }


}
