using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Right : MonoBehaviour , IPointerUpHandler, IPointerDownHandler{
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
		player.GetComponent<Animator> ().SetTrigger ("walk");
		click = false;

	}
	public void OnPointerDown(PointerEventData eventData){
		player.GetComponent<Animator> ().SetTrigger ("walk");
		player.transform.localScale = new Vector2 (1.82f, 1.82f);
		click = true;

	}
}
