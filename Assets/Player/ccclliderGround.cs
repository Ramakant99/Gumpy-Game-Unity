using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ccclliderGround : MonoBehaviour {
	public GameObject GameOver;

	public GameObject counter;
	public Text uiText;
	Vector2 startPos;
	public bool isground=false;
	// Use this for initialization

	void Start(){
		startPos = transform.position;
		transform.localScale=new Vector3 (0.5482f, 0.5482f,0);
	}
	void OnCollisionEnter2D(Collision2D collision)
	{

		if (collision.gameObject.tag == "EnemyBullet") {
			if (counter.GetComponent<CollectibleCount> ().countLife < 1) {

				GameOver.SetActive (true);
				Time.timeScale = 0.0f;

			}
			transform.position = startPos;
			counter.GetComponent<CollectibleCount> ().countLife--;
			uiText.text = counter.GetComponent<CollectibleCount> ().countLife.ToString ();
		}
	}

	}

