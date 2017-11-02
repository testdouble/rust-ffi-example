using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceBell : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)) {
				gameObject.GetComponent<AudioSource>().Play();
			}
		}
	}
}
