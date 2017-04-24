using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Jump : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {
	bool canDoubleJump=false;
	AudioSource aud;
	public GameObject player;
	public float o;

	// Use this for initialization
	void Start () {
		aud = GetComponent<AudioSource> ();

	}


	void Update(){

	

	}
	
	// Update is called once per frame
	public void OnPointerUp(PointerEventData eventData){




	}
	public void OnPointerDown(PointerEventData eventData){


		if (player.GetComponent<ColliderGround> ().isground == true) {
		
			if (canDoubleJump == false) {
				player.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * o);
				canDoubleJump = true;
			}
		} else if (canDoubleJump == true) {
				player.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * o);
				canDoubleJump = false;
			}	
	
		player.GetComponent<ColliderGround> ().isground = false;

			aud.Play ();


	}







}
