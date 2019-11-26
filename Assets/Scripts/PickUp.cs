using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    float distance = 10;

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

    void CatchFire()
    {
        Debug.Log("HEEEEEEEJ");
        if (GetComponent<Rigidbody>().position.x <= 5 && GetComponent<Rigidbody>().position.x >= -5)
        {
            if (GetComponent<Rigidbody>().position.z <= 5 && GetComponent<Rigidbody>().position.z >= -5)
            {
                Debug.Log("FIREEEEEE");              
            }
        }
    }

    void Update()
    {
        CatchFire();
    }


}
