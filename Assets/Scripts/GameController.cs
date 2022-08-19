using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject stork;

    Command btnR, btnL;

    bool isGameOn = false;

    void Start()
    {
        SetCommand();
        isGameOn = true;
        StartCoroutine(GreaterSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            btnL.Execute();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            btnR.Execute();
        }
        RotateStork();
    }

    void SetCommand()
    {
        btnL = new LeftRotate();
        btnR = new RightRotate();
    }

    void RotateStork()
    {
        stork.transform.Rotate(new Vector3(0, 0, GameManager.bs) * Time.deltaTime);
    }

    IEnumerator GreaterSpeed()
    {
        while(isGameOn)
        {
            Debug.Log("bi: " + GameManager.bi);
            //Debug.Log("bs: " + GameManager.bs);
            GameManager.bi += 0.001f;
            GameManager.bs += (stork.transform.rotation.z + stork.transform.rotation.z > 0 ? 2 : -2) * GameManager.bi * 0.01f;
            yield return new WaitForSeconds(0.001f);
        }
    }
}
