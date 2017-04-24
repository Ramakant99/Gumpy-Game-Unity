using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDestroy : MonoBehaviour {
	public GameObject sound;
	AudioSource au;
	public Text uiText;
	public GameObject counter;
	public GameObject prticle;
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
			GameObject e= Instantiate(prticle, transform.position,transform.rotation);
			counter.GetComponent<CollectibleCount>().countCoin++;
			uiText.text = counter.GetComponent<CollectibleCount>().countCoin.ToString ();
			Destroy (gameObject);
		}
	}



	}

