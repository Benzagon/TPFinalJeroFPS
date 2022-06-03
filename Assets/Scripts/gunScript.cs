using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{
    public GameObject bullet, bulletSpawnPoint;

    public float bulSpeed;
    public float bulDestroyTime;

    void Start()
    {
        
    }

    void Update()
    {
        //Click To Shoot
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Spawns Bullets
            GameObject bulClone = Instantiate(bullet);
            bulClone.transform.position = bulletSpawnPoint.transform.position;

            bulClone.GetComponent<Rigidbody>().AddForce(transform.forward * bulSpeed);

            Destroy(bulClone, bulDestroyTime);
        }

    }
}
