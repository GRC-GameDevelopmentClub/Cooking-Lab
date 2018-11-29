using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;

    private float lifetime = 2f;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, lifetime);
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = transform.right * speed;
	}
}
