using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    float speed = 50f;
    Instatiating instatiating;
    public Transform enemy;

    public Transform Enemy;
    public Transform Portal;

    float horizontalExtent;
    float verticalExtent;

    private void FixedUpdate()
    {
        if (transform.position.x > 100 || transform.position.y > 100)
        {
            Destroy(transform.gameObject);
        }
        if (transform.position.x < -100 || transform.position.y < -100)
        {
            Destroy(transform.gameObject);
        }
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Contains("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(transform.gameObject);

            horizontalExtent = Camera.main.orthographicSize * Screen.width / Screen.height;
            verticalExtent = Camera.main.orthographicSize;

            float x = Random.Range(-horizontalExtent, horizontalExtent);
            float y = Random.Range(-verticalExtent, verticalExtent);

            Instantiate(Portal, new Vector3(x, y, 0), Quaternion.identity);
            Instantiate(Enemy, new Vector3(x, y, 0), Quaternion.identity);
        }
        if (collision.tag.Contains("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(transform.gameObject);
            FindObjectOfType<DeathMenu>().Dead();
        }
    }
}
