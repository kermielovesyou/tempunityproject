using UnityEngine;
using System.Collections;

public class OrbitObject : MonoBehaviour {

	public GameObject[] orbiters;
	public float speed = 20f;

	void Start(){
		for (int i = 0; i < orbiters.Length; i++) {
			if (orbiters[i].GetComponent<Rigidbody> () == null) {
				orbiters [i].AddComponent (typeof(Rigidbody));
			}

			orbiters [i].GetComponent<Rigidbody> ().isKinematic = true;
		}

	}


	void Update () {
		for (int i = 0; i < orbiters.Length; i++) {
			orbiters[i].transform.RotateAround(transform.position, Vector3.up, speed  * Time.deltaTime);
		}

	}
}
