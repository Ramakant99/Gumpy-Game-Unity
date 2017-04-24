using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerKill : MonoBehaviour {

	public int hit;
	public GameObject GameOver,bugkill;
	public GameObject player;
	public GameObject counter;
	public Text uiText;
	Vector3 StartPos;
	AudioSource au;

	void Start(){

		StartPos=player.transform.position;
		au = GetComponent<AudioSource> ();
	}


	void Update(){


	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {  
			au.Play ();
			if (counter.GetComponent<CollectibleCount> ().countLife < 1) {

				GameOver.SetActive (true);
				Time.timeScale = 0.0f;

			}
			other.transform.position = StartPos;
			counter.GetComponent<CollectibleCount> ().countLife--;
			uiText.text = counter.GetComponent<CollectibleCount> ().countLife.ToString ();

		} else if (other.tag == "bullet") {
			bugkill.GetComponent<AudioSource> ().Play ();
			hit--;
			if(hit==0)
			Destroy (gameObject);

			Destroy (other.gameObject);

		}
	}
}

