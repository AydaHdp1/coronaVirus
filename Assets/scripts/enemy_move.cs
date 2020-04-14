using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour {
    public float speed = 40f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       // transform.Translate(new Vector3(1, 0, 0)*speed*Time.deltaTime);
        transform.Translate(new Vector3(0, 1, 0)*speed*Time.deltaTime);
	}
}
