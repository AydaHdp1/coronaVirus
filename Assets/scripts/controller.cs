using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
	public float pacSpeed;
	Vector3 pacPosition;
	// Use this for initialization
	void Start() {
		pacPosition = transform.position;
	}

	// Update is called once per frame
	void Update() {
		pacPosition.x += Input.GetAxis("Horizontal") * pacSpeed * Time.deltaTime;
		pacPosition.y += Input.GetAxis("Vertical") * pacSpeed * Time.deltaTime;
		transform.position = pacPosition;
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "enemy") {
			Destroy(gameObject);
		}
	}
}
