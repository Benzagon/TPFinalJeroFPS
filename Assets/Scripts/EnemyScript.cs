using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public Text killCounterTxt;
    public GameObject player, gameManager;

    void Start()
    {
       
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "bullet")
        {
            Destroy(gameObject);
            player.GetComponent<playerScript>().killedEnemy = true;
            gameManager.GetComponent<gameManagerScript>().playDeathNoise();
        }
    }
}
