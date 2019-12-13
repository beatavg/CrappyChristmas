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
    public int burnedPresents;
    //public GameObject test;

    public GameObject[] fires;
    
    void Start()
    {
        //explosion = GameObject.Find("ImageTarget/FireBall Variant");
        
        ImageTarget = GameObject.Find("ModelTarget");
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
        //Debug.Log("Apa");
        //Activate tree fire and activate smoke
        //fire.SetActive(true);
        fires[burnedPresents].SetActive(true);
        smoke.SetActive(true);
        Debug.Log("först " + burnedPresents);
        ++burnedPresents;

        //Debug.Log(ImageTarget.transform.Find("FireBall Variant (1)").gameObject);

        // Find the other presents
        GameObject truck = ImageTarget.transform.Find("Toy_Truck").gameObject;
        GameObject shoe = ImageTarget.transform.Find("shoe").gameObject;
        GameObject ball = ImageTarget.transform.Find("Soccer_Ball").gameObject;
        GameObject penguin = ImageTarget.transform.Find("PENGUIN").gameObject;
        GameObject rabbit = ImageTarget.transform.Find("RABBIT").gameObject;
        GameObject pig = ImageTarget.transform.Find("PIG").gameObject;
        GameObject pants = ImageTarget.transform.Find("Pants").gameObject;
        GameObject santa = ImageTarget.transform.Find("santa_hat").gameObject;

        // Update burnedPresents
        truck.GetComponent<PickUp>().burnedPresents = burnedPresents;
        shoe.GetComponent<PickUp>().burnedPresents = burnedPresents;
        ball.GetComponent<PickUp>().burnedPresents = burnedPresents;
        penguin.GetComponent<PickUp>().burnedPresents = burnedPresents;
        rabbit.GetComponent<PickUp>().burnedPresents = burnedPresents;
        pig.GetComponent<PickUp>().burnedPresents = burnedPresents;
        pants.GetComponent<PickUp>().burnedPresents = burnedPresents;
        santa.GetComponent<PickUp>().burnedPresents = burnedPresents;

        Debug.Log("här : " + burnedPresents);
        Debug.Log("härobjekt: " + this.burnedPresents);
        Debug.Log("där : " + pig.GetComponent<PickUp>().burnedPresents);
        //Debug.Log("sedan " + burnedPresents);
        // if (burnedPresents == 0)
        // { 
        //     //fires[1].SetActive(true);
        //     //heat.SetActive(true);
        //     Debug.Log("här "+ burnedPresents);
        // }
        // if(burnedPresents > 1)
        // {
        //     //heat.transform.localScale += new Vector3(0f, 1f, 0f);
        //     Debug.Log("där " + burnedPresents);
        // }

        //burnedPresents += 1;
        //Deactivate present and store position
        this.gameObject.SetActive(false);
        Vector3 endPosition = this.gameObject.transform.position;
        this.gameObject.transform.position = startPos;

        // Create present effects (fire, heat distortion) disappear
        GameObject fireClone = Instantiate(presentFirePrefab, endPosition, transform.rotation, ImageTarget.transform);
        //GameObject heatClone = Instantiate(heatPrefab, endPosition, transform.rotation, ImageTarget.transform);
        //Debug.Log(heatClone.transform.localRotation);
        //GameObject fireTreeClone = Instantiate(fires[burnedPresents], new Vector3(0f,0f,0f), transform.rotation, ImageTarget.transform);
       
        //heatClone.transform.localScale = new Vector3(0.5f, 2f, 0.5f);
        //heatClone.transform.localRotation = fireClone.transform.localRotation;
        //heatClone.transform.localRotation = new Quaternion(heatClone.transform.localRotation.x, heatClone.transform.localRotation.y, -360f);
        //heatClone.transform.Rotate = (0f, 0f, 0f, Self.World);
            //= (0, 0, -360);
        //test.SetActive(true);
        // Make those present effects disappear
        //GameObject clone = Instantiate(presentFirePrefab, endPosition, transform.rotation, ImageTarget.transform);
        int randomTimer = (int)Random.Range(1.0f, 4.0f);
        Destroy(fireClone, randomTimer);
        //Destroy(heatClone, randomTimer);

    }


}
