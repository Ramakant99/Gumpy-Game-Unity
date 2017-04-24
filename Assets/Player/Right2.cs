using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Right2 : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {
	public GameObject player;
	public float speed;
	bool click = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {

		if(click==true)
			player.GetComponent<Rigidbody2D> ().AddRelativeForce (Vector3.right * speed);

	}


	public void OnPointerUp(PointerEventData eventData){
		
		click = false;

	}
	public void OnPointerDown(PointerEventData eventData){
		
		player.transform.localScale = new Vector2 (0.5482f, 0.5482f);
		click = true;

	}
}
