using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leg : Stork
{
    public Animator legAnim;
    public float speed;

    private void Awake()
    {
        EventManager.StartEvent += Set;
    }

    void Update()
    {
        if (!GameManager.Instance.isGameOver)
        {
            speed = 1 + (GameManager.Instance.bi / 100) + (Mathf.Abs(GameManager.Instance.bs) / 1000);
            legAnim.speed = speed <= 2.5f ? speed : 2.5f;
            bodyZ = body.transform.rotation.eulerAngles.z;
            if (bodyZ < 30 || bodyZ > 330)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            }
            else if (bodyZ > 250)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, -10));
            }
            else
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 10));
            }
        }
        else
            legAnim.SetBool("isGameOver", true);
    }

    void Set()
    {
        legAnim.SetBool("isGameOver", false);
        legAnim.speed = 1f;
        bodyZ = body.transform.rotation.z;
    }

}
