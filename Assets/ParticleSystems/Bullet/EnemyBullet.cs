using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.right * 30;
	}


	void OnCollisionEnter2D(Collision2D collision)
	{

		Destroy (gameObject);
	}
}
