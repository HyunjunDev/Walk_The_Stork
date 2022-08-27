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
        GameManager.Instance.bs -= (GameManager.Instance.bi - 3);
    }
}
