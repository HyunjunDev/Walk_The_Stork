using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public GameObject body;
    private float bodyZ;

    private void Start()
    {
        bodyZ = body.transform.rotation.z;
    }
    void Update()
    {
        bodyZ = body.transform.rotation.z;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, bodyZ > 0 ? -bodyZ : Mathf.Abs(bodyZ)));
    }
}
