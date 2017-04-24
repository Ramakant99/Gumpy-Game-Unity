using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FireUnderwater : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {
	public GameObject bu,fireloc;
	float timestmp=0.5f;
	public float timebetshot;
	// Use this for initialization
	void Start () {


	}


	void Update(){



	}

	// Update is called once per frame
	public void OnPointerUp(PointerEventData eventData){




	}
	public void OnPointerDown(PointerEventData eventData){


		if (Time.time >= timestmp) {
			GameObject o = Instantiate (bu, fireloc.transform.position, fireloc.transform.rotation);
			GetComponent<AudioSource> ().Play ();
			Destroy (o, 2);
			timestmp = Time.time + timebetshot;
		}

 
	}


}
