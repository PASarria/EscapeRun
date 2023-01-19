using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartGame : MonoBehaviour
{

    public float timeLeft = 3.0f;
    public TMP_Text countdown; // used for showing countdown from 3, 2, 1 

    public GameObject playerObject;  // the player object to follow
    public float lerpSpeed = 0.5f;
    private Vector3 offset;
    public GameObject lostText;
    public AudioSource musicSource;
    public AudioClip BackgroundMusic;
    public AudioClip LoseSound;


    void Start()
    {
        offset = transform.position - playerObject.transform.position;
       
        
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        countdown.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            DestroyObject(playerObject);
            timeLeft = 0;
            lostText.SetActive(true);
            musicSource.Stop();
            
            
        }
    }
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(
           transform.position,                         // current camera position
           playerObject.transform.position + offset,   // new position plus our original offset
           lerpSpeed);                                 // the speed of smoothing
    }
}
