using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManagerScript : MonoBehaviour
{
    public AudioClip deathNoise;
    AudioSource audSource;

    void Start()
    {
        audSource = GetComponent<AudioSource>();
    }

    void Update()
    {
       if(Input.GetKey(KeyCode.Return))
       {
            SceneManager.LoadScene("Main");
       }
    }

    public void playDeathNoise()
    {
        audSource.clip = deathNoise;
        audSource.Play();
    }

    public void retryBtnClick()
    {
        SceneManager.LoadScene("Main");
    }
}
