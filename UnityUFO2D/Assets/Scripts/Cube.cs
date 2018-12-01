using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    float speed = 10f;

	// Update is called once per frame
	void Update () {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        Vector3 direction = input.normalized;
        Vector3 move = direction * speed;
        transform.Translate(move * Time.deltaTime);
	}
}
