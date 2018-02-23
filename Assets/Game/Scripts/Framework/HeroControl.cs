using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControl : MonoBehaviour
{
    public static HeroControl Instance;
    private Rigidbody2D Rigid;
    public float MoveSpeed=4f;
    public float JumpPower = 2;
    private HeroAnima heroAnima;
    public bool isDie = false;
    public Vector3 DefaultPosition;
    public bool IsDie
    {
        get { return isDie; }
        set
        {
            isDie = value;
            if (value)
            {
                UIManager.Instance.PushUIPanel("UILose");
            }
        }
    }
    void Awake()
    {
        Instance = this;
    }
	// Use this for initialization
	void Start () {
        Rigid = GetComponent<Rigidbody2D>();
        heroAnima = GetComponent<HeroAnima>();
        DefaultPosition = transform.position;
    }
    void FixedUpdate()
    {
        if (isDie)
        {
            heroAnima.DieState();
            return;
        }
        if (transform.localPosition.y < -500)
        {
            isDie = true;
        }
        float h = Input.GetAxis("Horizontal");
        if (Mathf.Abs(h - 0) > 0.01)
        {
            Rigid.velocity = new Vector2(MoveSpeed * h, Rigid.velocity.y);
            heroAnima.RunState(h < 0);
        }
        else
        {
            heroAnima.IdleState();
            Rigid.velocity = new Vector2(0, Rigid.velocity.y);
        }
        //else { Rigid.velocity = Vector2.zero; }
        if (Rigid.velocity.y == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Rigid.AddForce(Vector2.up * JumpPower);
                heroAnima.JumpState(true);
            }
            else
                heroAnima.JumpOver();
        }
    }
    public void ResetPlayer()
    {
        transform.position = DefaultPosition;
        IsDie = false;
    }
	// Update is called once per frame
	void Update () {
	}
}
