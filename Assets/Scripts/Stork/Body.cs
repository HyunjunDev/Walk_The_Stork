using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : Stork
{
    private bool isFront = false;

    private void Start()
    {
        EventManager.DieEvent += OnDead;
    }
    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.isGameOver)
        {
            if ((transform.rotation.eulerAngles.z < 255 && transform.rotation.eulerAngles.z > 180))
            {
                isFront = true;
                EventManager.DieEventing();
            }
            else if((transform.rotation.eulerAngles.z > 145 && transform.rotation.eulerAngles.z < 180))
            {
                isFront = false;
                EventManager.DieEventing();
            }
        }
    }

    public void OnDead()
    {
        inGameStork.SetActive(false);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        if (isFront)
            frontDead.SetActive(true);
        else
            backDead.SetActive(true);
    }    
}
