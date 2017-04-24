using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnderwaterBUllet : MonoBehaviour {
	




	Vector3 v;
	// Use this for initialization
	void Start () {

	
		v = new Vector3 (0.5482f, 0.5482f,0);

		if (GameObject.FindGameObjectWithTag("Player").transform.localScale == v)
			GetComponent<Rigidbody2D> ().velocity = Vector2.right * 20;
		else
			GetComponent<Rigidbody2D> ().velocity = Vector2.left*20;
	}

	// Update is called once per frame
	void Update () {

	}



	void OnCollisionEnter2D(Collision2D collision)
	{
		
		Destroy (gameObject);
	}
}
