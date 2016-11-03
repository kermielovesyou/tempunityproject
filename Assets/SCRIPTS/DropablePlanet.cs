using UnityEngine;
using System.Collections;

public class DropablePlanet : MonoBehaviour {

	void Update(){
		

		if (Input.GetMouseButtonDown (0)) {
			if (GetComponent<Rigidbody> () != null) {

				RaycastHit hit;
				if (Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward * 10f, out hit)) {

					Debug.Log ("hitting planet");

					if (hit.collider.GetComponent<DropablePlanet> () != null && hit.collider.GetComponent<DropablePlanet> () == this) {
						GetComponent<Rigidbody> ().isKinematic = false;
						Destroy (this);
					}

					Debug.DrawRay (Camera.main.transform.position, Camera.main.transform.forward*10f);
				}
					


			}

		}


	}
}
