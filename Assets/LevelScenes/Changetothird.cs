﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Changetothird : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void OnTriggerEnter2D(Collider2D other)
	{

		if(other.tag=="Player")
		SceneManager.LoadScene ("Comingsoon");


	}
}
