using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBG : MonoBehaviour
{
    public enum eBGtype
    {
        Slowest,
        Slow,
        Common,
        Fast,
        Fastest
    };

    [SerializeField]
    Transform[] backgrounds;
    [SerializeField]
    float speed = 0f;
    [SerializeField]
    float startPos = 0f;
    [SerializeField]
    float endPos = 0f;

    public eBGtype bgType;

    private void Update()
    {
        switch(bgType)
        {
            case eBGtype.Slowest:
                speed = GameManager.bi * -0.1f;
                break;
            case eBGtype.Slow:
                speed = GameManager.bi * -0.2f;
                break;
            case eBGtype.Common:
                speed = GameManager.bi * -0.45f;
                break;
            case eBGtype.Fast:
                speed = GameManager.bi * -0.6f;
                break;
            case eBGtype.Fastest:
                speed = GameManager.bi * -0.8f;
                break;
        }
        for(int i=0;i<backgrounds.Length;i++)
        {
            backgrounds[i].position += new Vector3(speed, 0, 0) * Time.deltaTime;
            if (backgrounds[i].position.x <= endPos)
                backgrounds[i].position = new Vector3(startPos, backgrounds[i].position.y, backgrounds[i].position.z);
        }
    }
}
