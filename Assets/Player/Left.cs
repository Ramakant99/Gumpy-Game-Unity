using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Left : MonoBehaviour , IPointerUpHandler, IPointerDownHandler{
	public GameObject player;

	bool click = false;
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(click==true)
			player.GetComponent<Rigidbody2D> ().AddRelativeForce (Vector3.left * speed);
	
	}



	public void OnPointerUp(PointerEventData eventData){
		click = false;
	
		player.GetComponent<Animator> ().SetTrigger ("walk");

	}
	public void OnPointerDown(PointerEventData eventData){

		player.transform.localScale = new Vector2 (-1.82f, 1.82f);
		player.GetComponent<Animator> ().SetTrigger ("walk");
		click = true;

	}
}
