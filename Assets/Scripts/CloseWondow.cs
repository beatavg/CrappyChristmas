using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseWondow : MonoBehaviour
{
    public Button button;
    public GameObject window = GameObject.Find("/Canvas/Image");
    void Start()
    {
        button.onClick.AddListener(Close);
    }

    void Close()
    {
        window.SetActive(false);
    }
}
