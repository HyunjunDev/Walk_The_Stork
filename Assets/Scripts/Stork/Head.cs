using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : Stork
{
    private void Start()
    {
        bodyZ = body.transform.rotation.z;
        EventManager.StartEvent += Set;
    }

    void Update()
    {
        bodyZ = body.transform.rotation.z;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, bodyZ > 0 ? -bodyZ : Mathf.Abs(bodyZ)));
    }

    private void Set()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }
}
