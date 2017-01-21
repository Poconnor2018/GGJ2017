using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    
    public float maxSpeed, noiseSpeed;
    const float resetSpeed = .02f;
    Vector3 movement;
    public AudioClip step;
    public AudioSource m_audioSource;

	// Use this for initialization
	void Start () {
        noiseSpeed = maxSpeed - .3f;
        m_audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
        if ( Input.GetButton ( "Run" ) )
            maxSpeed += .001f;
        else
            maxSpeed += resetSpeed;
        movement.x = Input.GetAxis ( "Horizontal" ) * maxSpeed;
        movement.y = Input.GetAxis ( "Vertical" ) * maxSpeed;
    }

    void FixedUpdate () {
            
        Vector3 speed = movement;
        if ( speed.magnitude > noiseSpeed )
            m_audioSource.PlayOneShot (step);

        transform.position += speed;
    }
}
