using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {

    public float moveSpeed = 5f;
    Rigidbody2D rb2d;
    Vector2 velocity;
    PlayerControl control;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + velocity * Time.deltaTime);
    }


    public void Move(Vector2 _velocity)
    {
        velocity = _velocity;
    }

   
}
