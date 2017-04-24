using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JJump : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {
	
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
	public void OnPointerDown (PointerEventData eventData)
	{



				player.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * o);
			
			aud.Play ();
		}
	}
