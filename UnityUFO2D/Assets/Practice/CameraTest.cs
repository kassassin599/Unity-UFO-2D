using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour {


    public GameObject cube;

    private Vector3 offset;

	void Start () {
        offset = transform.position - cube.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = cube.transform.position + offset;
	}
}
