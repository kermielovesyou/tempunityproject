using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cruscarp : MonoBehaviour {

	DialogueHUD dialogueHUD;

	// Use this for initialization
	void Awake () {
		dialogueHUD = FindObjectOfType<DialogueHUD> ();
		dialogueHUD.Enable (false);

	}


	void OnTriggerEnter (Collider coll) {
		dialogueHUD.Enable (true);
	}


	void OnTriggerExit (Collider coll) {
		dialogueHUD.Enable (false);
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
