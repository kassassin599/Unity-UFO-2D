using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

    public Transform targetTransform;
    float speed = 7f;
	
	void Update () {
        Vector3 displacementFromTarget = targetTransform.position - transform.position;
        Vector3 directionToTarget = displacementFromTarget.normalized;
        Vector3 move = directionToTarget * speed;

        float distanceToTarget = displacementFromTarget.magnitude;
        if (distanceToTarget > 1.5f)
        {
            transform.Translate(move * Time.deltaTime);
        }

        
	}
}
