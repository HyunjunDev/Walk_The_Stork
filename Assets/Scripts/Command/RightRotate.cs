using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRotate : Command
{
    public override void Execute()
    {
        RightRot();
    }

    void RightRot()
    {
        GameManager.bs -= (GameManager.bi - 3);
    }
}
