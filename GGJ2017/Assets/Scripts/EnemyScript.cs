using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public Transform target;
    public float maxSpeed;
    Vector3 moveDir;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        moveDir = target.position - transform.position;
        moveDir.Normalize ();
        transform.position += moveDir * maxSpeed;
	}
}
