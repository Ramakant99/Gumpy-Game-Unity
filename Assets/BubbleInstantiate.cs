using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleInstantiate : MonoBehaviour {
	public GameObject bubble;
	// Use this for initialization
	GameObject o;
	private float InstantiationTimer = 1f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		InstantiationTimer -= Time.deltaTime;
		if (InstantiationTimer <= 0)
		{
			o = Instantiate (bubble, transform.position, transform.rotation);

			InstantiationTimer = 1f;
		}



	}
}
