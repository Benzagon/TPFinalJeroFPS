using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagScript : MonoBehaviour
{
    public float flagRaiseSpeed;
    bool flagIsActive = false;

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        if(flagIsActive == true && transform.localPosition.y <= 21)
        {
            transform.position += new Vector3(0f, flagRaiseSpeed, 0f);
        }
    }

    public void activateFlag()
    {
        if(flagIsActive == false)
        {
            flagIsActive = true;
            gameObject.SetActive(true);
        }
    }
}
