using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinText : MonoBehaviour
{
    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.name == "Finish Line")
        {
            winText.SetActive(true);
        }
    }
 }
