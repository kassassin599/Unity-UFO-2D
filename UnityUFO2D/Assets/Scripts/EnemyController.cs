using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour {
    
    Transform targetTransform;
    float speed = 5f;


    private void Start()
    {
        targetTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        if (targetTransform != null)
        {
            Vector2 displacementFromTarget = targetTransform.position - transform.position;
            Vector2 directionToTarget = displacementFromTarget.normalized;
            Vector2 move = directionToTarget * speed;

            float distanceFromTarget = displacementFromTarget.magnitude;

            if (distanceFromTarget > 3f)
            {
                transform.Translate(move * Time.deltaTime);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Contains("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(transform.gameObject);
            FindObjectOfType<DeathMenu>().Dead();
        }
    }
}
