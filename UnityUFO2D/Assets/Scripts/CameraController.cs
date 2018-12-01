using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    //public GameObject player;
    Transform player;
    private Vector3 offset;

    DeathMenu dm;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        dm = GetComponent<DeathMenu>();
        if (player!=null)
            offset = transform.position - player.transform.position;
        else
        {
            dm.Dead();
        }

	}
	
	// Update is called once per frame
	void LateUpdate () {
        if(player!=null)
        transform.position = player.transform.position + offset;
        else
        {
            //dm.Dead();
        }
	}
}
