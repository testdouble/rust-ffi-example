using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceBell : MonoBehaviour {
	void Start () {
		FFI.connectToServer("0.0.0.0:12345");
	}

	void OnDestroy () {
		FFI.disconnectFromServer();
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)) {
				gameObject.GetComponent<AudioSource>().Play();
				FFI.sendDing();
			}
		}
	}
}
