using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Quit : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void OnPointerUp(PointerEventData eventData){




	}
	public void OnPointerDown(PointerEventData eventData){


		Application.Quit ();

	}
}
