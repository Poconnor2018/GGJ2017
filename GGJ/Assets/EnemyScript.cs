using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour {

    NavMeshAgent agent;
    Transform player;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent> ();
        player = GameObject.Find ( "Player" ).transform;
        agent.updateRotation = false;
	}
	
	// Update is called once per frame
	void Update () {
        agent.destination = player.position;
		
	}
}
