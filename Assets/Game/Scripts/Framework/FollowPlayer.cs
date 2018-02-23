using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    private Transform player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        float x = Mathf.Lerp(transform.position.x, player.position.x, Time.deltaTime * 4);
        transform.position = new Vector3(x, transform.position.y,-18.869f);
	}
}
