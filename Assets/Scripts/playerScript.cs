using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerScript : MonoBehaviour
{
    public int health;
    int enemiesKilled;
    Vector3 startPos;

    public bool killedEnemy = false;

    public GameObject hp1, hp2, hp3;
    public GameObject gun;
    public GameObject winText;

    public Text killCounterTxt;
    public Text timer;

    float time = 0f;



    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if(killedEnemy)
        {
            enemiesKilled++;

            killCounterTxt.text = ("Enemies Killed " + enemiesKilled);
            killedEnemy = false;
        }
        
        if(Input.GetKey(KeyCode.R))
        {
            startPos = new Vector3(30f, 10.5f, -37f);
        }

        time += Time.deltaTime;
        timer.text = Mathf.Floor(time).ToString();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.tag == "death")
        {
            health--;

            if (health > 0)
            {
                transform.position = startPos;

                if (health == 2)
                {
                    hp3.SetActive(false);
                    hp2.SetActive(true);
                }
                else if(health == 1)
                {
                    hp2.SetActive(false);
                    hp1.SetActive(true);
                }
            }
            else
            {
                SceneManager.LoadScene("Main");
            }
            transform.position = startPos;
        }

        //ShotgunActive
        if(hit.collider.name == "ShotGunMod")
        {
            gun.GetComponent<gunScript>().gunMod = true;
        }

        //FlagPole
        if (hit.collider.name == "FlagPole")
        {
            winText.SetActive(true);
        }

        //CP
        else if(hit.collider.name == "CP")
        {
            startPos = new Vector3(30f, 10.5f, -37f);
        }

    }
}
