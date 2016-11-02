using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueChoiceUI : MonoBehaviour {

	[SerializeField] Text choiceText;

	// Use this for initialization
	void Start () {
	
	}

	public void Enable (bool b) {
		gameObject.SetActive (b);
	}

	public void SetText (string s) {
		choiceText.text = s;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
