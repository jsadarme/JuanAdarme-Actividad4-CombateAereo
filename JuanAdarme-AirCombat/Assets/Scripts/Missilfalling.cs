using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missilfalling : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0, 0, 5);
		
	}
		void OnCollisionEnter(Collision collision) {

			Destroy (collision.collider.gameObject);

		//Se destruye el objeto impactado
		Destroy (collision.collider.gameObject);

		//Se destruye el misils
		Destroy (this.gameObject);
		
	}
}
