using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	
	Vector3 v;
	// Use this for initialization
	void Start () {
		v = new Vector3 (1.82f, 1.82f,0);

		if (GameObject.FindGameObjectWithTag("Player").transform.localScale == v)
			GetComponent<Rigidbody2D> ().velocity = Vector2.right * 30;
		else
			GetComponent<Rigidbody2D> ().velocity = Vector2.left*30;
	}
	
	// Update is called once per frame
	void Update () {

	}



	void OnCollisionEnter2D(Collision2D collision)
	{

		Destroy (gameObject);
	}
}
