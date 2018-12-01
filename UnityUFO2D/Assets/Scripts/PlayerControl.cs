using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControl : MonoBehaviour {


    Vector2 velocity;
    Rigidbody2D rb2d;

	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}

    public void Move(Vector2 _velocity)
    {
        velocity = _velocity;
    }

    public void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + velocity * Time.deltaTime);
    }
}
