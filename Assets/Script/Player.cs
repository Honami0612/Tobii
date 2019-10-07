using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float x;
    private float z;
    Rigidbody rb;
    private float speed = 3f;
    Vector3 playerPos;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        playerPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        z = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
        rb.MovePosition(transform.position = new Vector3(x, 0, z));
        playerPos = transform.position;
	}
}
