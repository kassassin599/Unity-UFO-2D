using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatiating : MonoBehaviour {

    public Transform Enemy;
    public Transform Portal;

    float horizontalExtent;
    float verticalExtent;


    private void Start()
    {
        horizontalExtent = Camera.main.orthographicSize * Screen.width / Screen.height;
        verticalExtent = Camera.main.orthographicSize;

        float x = Random.Range(-horizontalExtent, horizontalExtent);
        float y = Random.Range(-verticalExtent, verticalExtent);

        Instantiate(Portal, new Vector3(x, y, 0), Quaternion.identity);
        Instantiate(Enemy, new Vector3(x, y, 0), Quaternion.identity);
    }
}
