using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveVertical : MonoBehaviour {
	public GameObject up,dwn;
	// Use this for initialization
	bool lftt=true;

	void Start () {
		transform.position = up.transform.position;

	}

	// Update is called once per frame
	void Update () {


		if (transform.position == up.transform.position) {
			lftt = true;
			GetComponent<SpriteRenderer> ().flipX = false;
		} else if (transform.position == dwn.transform.position) {
			lftt = false;
			GetComponent<SpriteRenderer> ().flipX = true;
		}
		if(lftt==true)
			transform.position = Vector2.MoveTowards(transform.position, dwn.transform.position, 0.1f);
		else 
			transform.position = Vector2.MoveTowards(transform.position, up.transform.position, 0.1f );

	}
}