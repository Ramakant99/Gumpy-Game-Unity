using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void OnPointerUp(PointerEventData eventData){




	}
	public void OnPointerDown(PointerEventData eventData){


		SceneManager.LoadScene ("Level01");

	}
}
