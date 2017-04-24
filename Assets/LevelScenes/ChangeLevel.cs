using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour {
	private float InstantiationTimer = 10f;
	// Use this for initialization
	void Start () {
		InstantiationTimer = Time.time+InstantiationTimer;
	}
	
	// Update is called once per frame
	void Update () {


		if (Time.time>InstantiationTimer) {

			SceneManager.LoadScene ("Level1");
		}

	}
}
