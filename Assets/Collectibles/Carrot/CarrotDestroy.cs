using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CarrotDestroy : MonoBehaviour {
	public GameObject sound;
	public Text uiText;
	public GameObject counter;
	AudioSource au;
	// Use this for initialization
	void Start () {
		au = sound.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {






	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{   
			au.Play ();
			counter.GetComponent<CollectibleCount>().countCarrot++;
			uiText.text = counter.GetComponent<CollectibleCount>().countCarrot.ToString ();
			Destroy (gameObject);
		}
	}

}
