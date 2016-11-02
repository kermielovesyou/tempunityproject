using UnityEngine;
using System.Collections;

public class RoomPictureTrigger : MonoBehaviour {
	GameManager gameManager;
	[SerializeField] GameObject fishPicture;

	// Use this for initialization
	void Awake () {
		gameManager = FindObjectOfType<GameManager> ();
		fishPicture.GetComponent<Renderer> ().enabled = false;
	}


	void OnTriggerEnter (Collider coll) {
		if (gameManager.SaidOkToFish) {
			fishPicture.GetComponent<Renderer> ().enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
