using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public Text killCounterTxt;
    public GameObject player;

    int enemiesKilled;

    void Start()
    {
        enemiesKilled = player.GetComponent<playerScript>().enemiesKilled;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "bullet")
        {
            Destroy(gameObject);
            enemiesKilled += 1;

            killCounterTxt.text = ("Enemies Killed " + enemiesKilled);
            player.GetComponent<playerScript>().enemiesKilled = enemiesKilled;
        }
    }
}
