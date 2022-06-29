using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonFireScript : MonoBehaviour
{
    public GameObject cannonBall, ballSpawnPoint;

    public float ballSpeed;
    public float ballDestroyTime;
    public float cannonFireDelay;

    float spawnBallTimer;

    void Start()
    {
        
    }

    void Update()
    {
        spawnBallTimer += Time.deltaTime;
        if(spawnBallTimer >= cannonFireDelay)
        {
            fireBall();
            spawnBallTimer = 0f;
        }
    }

    void fireBall()
    {
        //Spawns Cannon Balls
        GameObject bulClone = Instantiate(cannonBall);
        bulClone.transform.position = ballSpawnPoint.transform.position;

        bulClone.GetComponent<Rigidbody>().AddForce(transform.right * ballSpeed);

        Destroy(bulClone, ballDestroyTime);
    }
}
