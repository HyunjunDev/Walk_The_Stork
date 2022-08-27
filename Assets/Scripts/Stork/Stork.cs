using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stork : MonoBehaviour
{
    private Animator anim;
    public GameObject body;
    protected float bodyZ;
    public GameObject inGameStork;
    protected GameObject frontDead;
    protected GameObject backDead;
    // Start is called before the first frame update

    private void Awake()
    {
        frontDead = GameObject.Find("DeadStork").transform.Find("FrontDeadStork").gameObject;
        backDead = GameObject.Find("DeadStork").transform.Find("BackDeadStork").gameObject;
    }
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnEnterNextScene()
    {
        EventManager.StartEventing();
    }

    public void OnEnterbeforeScene()
    {
        UIManager.Instance.ExplainFalse();
        UIManager.Instance.GameOverFalse();
        GameManager.Instance.score = 0f;
        frontDead.SetActive(false);
        backDead.SetActive(false);
    }
}
