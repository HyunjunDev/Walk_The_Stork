using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBG : MonoBehaviour
{
    [SerializeField]
    Transform[] backgrounds;
    [SerializeField]
    float speed = 0f;
    [SerializeField]
    float startPos = 0f;
    [SerializeField]
    float endPos = 0f;

    private void Update()
    {
        for(int i=0;i<backgrounds.Length;i++)
        {
            backgrounds[i].position += new Vector3(speed, 0, 0) * Time.deltaTime;
            if (backgrounds[i].position.x <= endPos)
                backgrounds[i].position = new Vector3(startPos, backgrounds[i].position.y, backgrounds[i].position.z);
        }
    }
}
