using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRotate : Command
{
    public override void Execute()
    {
        LeftRot();
    }

    void LeftRot()
    {
        GameManager.Instance.bs += (GameManager.Instance.bi - 3);
    }
}
