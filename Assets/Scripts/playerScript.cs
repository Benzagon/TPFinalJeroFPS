using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerScript : MonoBehaviour
{
    public int health;
    public int enemiesKilled;
    Vector3 startPos;

    public GameObject hp1, hp2, hp3;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        
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
                SceneManager.LoadScene(SceneManager.GetActiveScene);
            }
            transform.position = startPos;
            Debug.Log("Ded");
        }
    }
}
