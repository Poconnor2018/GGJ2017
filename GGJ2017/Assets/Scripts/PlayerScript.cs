using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public float maxSpeed = .01f;
    Vector3 movement;
    public GameObject proj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        movement.x = Input.GetAxis ( "Horizontal" );
        movement.y = Input.GetAxis ( "Vertical" );
        if ( Input.GetButtonDown( "Fire1" ) ) {
            Instantiate ( proj, transform.position, Quaternion.identity ).GetComponent<EnemyScript>().target = FindClosestTarget();
        }
	}

    void FixedUpdate () {
        transform.position += movement*maxSpeed;
    }

    Transform FindClosestTarget () {
        if ( GameObject.Find ( "Enemy" ) )
            return GameObject.Find ( "Enemy" ).transform;
        return transform;
    }
}
