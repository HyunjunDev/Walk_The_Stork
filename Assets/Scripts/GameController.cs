using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject storkBody;
    public GameObject stork;

    Command btnR, btnL;

    void Awake()
    {
        btnL = new LeftRotate();
        btnR = new RightRotate();
        EventManager.StartEvent += Setting;
        EventManager.DieEvent += StopAllCoroutines;
    }

    void Update()
    {
        if (!GameManager.Instance.isGameOver)
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
        else
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                GameManager.Instance.StartGame();
            }
        }
    }

    void Setting()
    {
        StartCoroutine(GreaterSpeed());
        StartCoroutine(GreaterScore());
    }

    void RotateStork()
    {
        storkBody.transform.Rotate(new Vector3(0, 0, GameManager.Instance.bs) * Time.deltaTime);
    }

    IEnumerator GreaterSpeed()
    {
        while (true)
        {
            //Debug.Log("bi: " + GameManager.Instance.bi);
            //Debug.Log("bs: " + GameManager.bs);
            GameManager.Instance.bi += 0.001f;
            GameManager.Instance.bs += (storkBody.transform.rotation.z + storkBody.transform.rotation.z > 0 ? 2 : -2) * GameManager.Instance.bi * 0.01f;
            yield return new WaitForSeconds(0.001f);
        }
    }

    IEnumerator GreaterScore()
    {
        while (true)
        {
            GameManager.Instance.AddScore((GameManager.Instance.bi - 3f) * 0.008f);
            UIManager.Instance.UpdateScoreText();
            yield return new WaitForSeconds(0.1f);
        }
    }
}
