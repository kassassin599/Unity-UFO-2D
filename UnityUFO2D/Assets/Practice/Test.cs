using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public int health = 3;
    public float speed = 10f;

    private void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 dir = input.normalized;
        Vector2 move = dir * speed;
        transform.Translate(move*Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            if (health <= 0)
            {
                print(health);
               // Destroy(transform.gameObject);
            }
            health--;
        }
    }
}
