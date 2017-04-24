using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour {
	public GameObject bu;
	GameObject o;
	private float InstantiationTimer = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		InstantiationTimer -= Time.deltaTime;
		if (InstantiationTimer <= 0)
		{
			o = Instantiate (bu, transform.position, transform.rotation);
			o.transform.Rotate(Vector3.back*90f); 
			GetComponent<AudioSource> ().Play ();
			Destroy (o, 2);
			InstantiationTimer = 1f;
		}
	}
}
