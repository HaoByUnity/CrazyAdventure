using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColliderCondition : MonoBehaviour
{
    public UnityEvent OnCollisionHandler;
    public bool Die = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (Die)
        { HeroControl.Instance.isDie = true; }
        OnCollisionHandler.Invoke();
    }
    //void OnTriggerEnter2D(Collision2D collision)
    //{
    //    if (Die)
    //    { HeroControl.Instance.isDie = true; }
    //    OnCollisionHandler.Invoke();
    //}
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
