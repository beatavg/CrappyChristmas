using UnityEngine;
using System.Collections;

public class OpenPresent : MonoBehaviour
{    
    public GameObject present;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //transform.GetChild(2).gameObject.SetActive(true);
            //gameObject.SetActive(false);
            Vector3 p = transform.position;
            Destroy(gameObject);
            Instantiate(present, p, Quaternion.identity);


        }

    }
}
