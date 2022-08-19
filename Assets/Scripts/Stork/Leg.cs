using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leg : MonoBehaviour
{
    public GameObject body;
    public Animator anim;
    public float bodyZ;
    public float speed;

    private void Start()
    {
        bodyZ = body.transform.rotation.z;
    }

    void Update()
    {
        speed = 1 + (GameManager.bi / 100) + (Mathf.Abs(GameManager.bs) / 1000);
        anim.speed = speed <= 2.5f ? speed : 2.5f;
        bodyZ = body.transform.rotation.eulerAngles.z;
        if (bodyZ<30||bodyZ>330)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        else if(bodyZ > 250)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, -10));
        }
        else
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 10));
        }
    }
}
