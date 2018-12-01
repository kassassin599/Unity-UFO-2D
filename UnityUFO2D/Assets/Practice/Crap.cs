using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crap : MonoBehaviour {

    float speed = 10f;
    private Rigidbody rb;

    float horizontalExtent;
    float verticalExtent;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

        horizontalExtent = Camera.main.orthographicSize * Screen.width / Screen.height;
        verticalExtent = Camera.main.orthographicSize;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        Vector3 direction = input.normalized;
        Vector3 force = direction * speed;
        rb.velocity = force;
        //transform.Translate(force*Time.deltaTime);
        
	}
}
