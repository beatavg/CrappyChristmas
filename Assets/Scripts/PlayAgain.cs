using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayAgain : MonoBehaviour
{
    // Start is called before the first frame update

    public Button button;
    public GameObject gameOver;

    void Start()
    {
        button.onClick.AddListener(Reload);
    }

    void Reload()
    {
        gameOver.SetActive(false);
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }

}
