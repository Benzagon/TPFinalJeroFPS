using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
       
    }

    public void playDeathNoise()
    {
        audSource.clip = deathNoise;
        audSource.Play();
    }
}
