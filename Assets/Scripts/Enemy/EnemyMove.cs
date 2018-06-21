using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public float moveForce = 0f;
    private Rigidbody rbody;
    public Vector3 movDir;
    public LayerMask whatIsWall;
    public float maxDistFromWall;

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody>();
        movDir = ChooseDirection();
        transform.rotation = Quaternion.LookRotation(movDir);
	}

    Vector3 ChooseDirection()
    {
        System.Random random = new System.Random();
        int i = random.Next(0,3);
        Vector3 vector3 = new Vector3();

        if (i == 0)
        {
            vector3 = transform.forward;
        }else if (i == 1)
        {
            vector3 = transform.forward;
        }else if (i == 2)
        {
            vector3 = transform.right;
        }else if (i == 3)
        {
            vector3 = transform.right;
        }

        return vector3;
    }

    // Update is called once per frame
	void Update () {
        rbody.velocity = movDir * moveForce;

        if (Physics.Raycast(transform.position,transform.forward, maxDistFromWall, whatIsWall))
        {
            movDir = ChooseDirection();
            transform.rotation = Quaternion.LookRotation(movDir);
        }
    }
}
