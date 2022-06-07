using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{
    public GameObject bullet, bulletSpawnPoint;

    public float bulSpeed;
    public float bulDestroyTime;

    public bool gunMod = false;

    public AudioClip shootSound;
    AudioSource audSrc;

    void Start()
    {
        audSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        //Click To Shoot
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Standard gun code
            if (gunMod == false)
            {
                //Spawns Bullets
                GameObject bulClone = Instantiate(bullet);
                bulClone.transform.position = bulletSpawnPoint.transform.position;

                bulClone.GetComponent<Rigidbody>().AddForce(transform.forward * bulSpeed);

                Destroy(bulClone, bulDestroyTime);

                audSrc.clip = shootSound;
                audSrc.Play();
            }

            //Shotgun Code
            else
            {
                for (int i = 1; i <= 12; i++)
                {
                    GameObject bulClone = Instantiate(bullet);
                    bulClone.transform.position = bulletSpawnPoint.transform.position;

                    bulClone.GetComponent<Rigidbody>().AddForce(transform.forward * bulSpeed * i);

                    Destroy(bulClone, bulDestroyTime);

                    audSrc.clip = shootSound;
                    audSrc.Play();
                }
            }
        }

    }
}
