using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAnima : MonoBehaviour
{
    private Animator anima;
	// Use this for initialization
	void Start () {
        anima = GetComponent<Animator>();
	}
    public void IdleState()
    {
        anima.SetBool("Die", false);
        anima.SetBool("JumpL", false);
        anima.SetBool("JumpR", false);
        anima.SetFloat("Run", 1.0f);
    }
    public void RunState(bool isLeft)
    {
        float value = isLeft ? 0 : 2;
        anima.SetFloat("Run", value);
    }
    public void JumpState(bool isLeft)
    {
        if (isLeft)
            anima.SetBool("JumpL", true);
        else
            anima.SetBool("JumpR", true);

    }
    public void JumpOver()
    {
            anima.SetBool("JumpL", false);
            anima.SetBool("JumpR", false);

    }
    bool isDead = false;
    public void DieState()
    {
        if (!isDead)
        {
            anima.SetBool("Die", true);
            isDead = false;
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
