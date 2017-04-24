using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class LevelRestart : MonoBehaviour , IPointerUpHandler, IPointerDownHandler{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerUp(PointerEventData eventData){


	}
	public void OnPointerDown(PointerEventData eventData){
		Time.timeScale = 1.0f;
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

}
