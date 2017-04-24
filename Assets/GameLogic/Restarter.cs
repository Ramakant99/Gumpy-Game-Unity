using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {


		public GameObject GameOver;
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


			if (Input.GetKeyDown (KeyCode.Escape))
				Application.Quit ();

		}

		private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
			{  
				au.Play ();
				if (counter.GetComponent<CollectibleCount> ().countLife <1) {

					GameOver.SetActive (true);
					Time.timeScale = 0.0f;
				
				}
				other.transform.position=StartPos;
				counter.GetComponent<CollectibleCount> ().countLife--;
				uiText.text = counter.GetComponent<CollectibleCount> ().countLife.ToString();
               
            }
        }
    }
}
