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
        GameManager.bs += (GameManager.bi - 3);
    }
}
