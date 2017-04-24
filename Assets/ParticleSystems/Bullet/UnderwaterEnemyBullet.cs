using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderwaterEnemyBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.left * 30;
	}


	void OnCollisionEnter2D(Collision2D collision)
	{

		Destroy (gameObject);
	}
}
