using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderwaterCamera : MonoBehaviour {
	public GameObject refrence;
	float posx;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		posx=refrence.transform.position.x;
		transform.position = new Vector3 (posx, transform.position.y, transform.position.z);
	}
}
