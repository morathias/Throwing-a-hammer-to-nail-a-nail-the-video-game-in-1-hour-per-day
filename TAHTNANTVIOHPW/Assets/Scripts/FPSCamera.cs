using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour {
    public GameObject hammerPrefab;

    Vector3 rot = Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rot.y += Input.GetAxisRaw("Mouse X");
        rot.x -= Input.GetAxisRaw("Mouse Y");

        transform.rotation = Quaternion.Euler(rot);

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject g = Instantiate(hammerPrefab);
            g.transform.position = transform.position;
            g.transform.rotation = transform.rotation;
            g.GetComponent<Rigidbody>().AddForce(transform.forward * 2000f);
            g.GetComponent<Rigidbody>().angularVelocity = transform.right * 2000;
        }
	}
}
