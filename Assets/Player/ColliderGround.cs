using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColliderGround : MonoBehaviour {
	public GameObject GameOver;

	public GameObject counter;
	public Text uiText;
	public bool isground=false;
	// Use this for initialization
	Vector2 startPos;
	void Start(){
		startPos = transform.position;
		transform.localScale=new Vector3 (1.82f, 1.82f,0);
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
		} else {
			ContactPoint2D cont = collision.contacts [0];
			if (cont.point.y < transform.position.y)
				isground = true;
		}
			
		}
	}





