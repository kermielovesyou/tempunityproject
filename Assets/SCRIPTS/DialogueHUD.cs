using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueHUD : MonoBehaviour {

	Canvas canvas;
	[SerializeField] Text backgroundText;
	DialogueChoiceUI[] choices;

	Dialogue currentDialogue;

	// Use this for initialization
	void Awake () {
		canvas = GetComponent<Canvas> ();
		choices = GetComponentsInChildren<DialogueChoiceUI> ();

		Choice[] cs;
		Dialogue d;
		d = new Dialogue ("Safe travels! I look forward to following your journey.", new Choice[0]);
		cs = new Choice[] {
			new Choice ("Okay", d, true), 
			new Choice ("I don't really have time for that, sorry!", null, false)
		};
		d = new Dialogue("I'm always stuck in here. Say, would you send me pictures from your journey?", cs);
		cs = new Choice[] {
			new Choice ("I don't know", d, false),
			new Choice ("Wandering around", d, false),
			new Choice ("Why do you want to know?", d, false)
		};
		d = new Dialogue ("What are you doing here?", cs);
		cs = new Choice[] {
			new Choice ("Yeah, sure", d, false),
			new Choice ("Sorry, in a hurry.", null, false)
		};
		d = new Dialogue ("Hello, will you stop for a chat?", cs);
		currentDialogue = d;

		LoadCurrentDialogue ();
	}


	void LoadCurrentDialogue () {
		if (currentDialogue != null) {
			backgroundText.text = currentDialogue.Text;
			Choice[] c = currentDialogue.Choices;
			for (int i = 0; i < choices.Length; i++) {
				if (i < c.Length) {
					choices [i].Enable (true);
					choices [i].SetText (c [i].Text);
				} else {
					choices [i].Enable (false);
				}
			}
		} else {
				
			Enable (false);
		}
	}

	public void Enable (bool b) {
		canvas.enabled = b && currentDialogue != null;
	}

	void EnableOptionsCount (int n) {
		for (int i = 0; i < choices.Length; i++) {
			choices [i].Enable (i < n);
		}
	}

	void MakeChoice (int index) {
		Debug.Assert (currentDialogue != null);

		if (index < currentDialogue.Choices.Length) {
			if (currentDialogue.Choices [index].SaidOKToFish) {
				FindObjectOfType<GameManager> ().RecordSaidOkToFish ();
			}
			currentDialogue = currentDialogue.Choices [index].NexDialogue;
			LoadCurrentDialogue ();
		}

		
	}
	
	// Update is called once per frame
	void Update () {
		if (canvas.enabled && currentDialogue != null) {
			// read key inputs
			if (Input.GetKeyUp ("1")) {
				MakeChoice (0);
			} else if (Input.GetKeyUp ("2")) {
				MakeChoice (1);
			} else if (Input.GetKeyUp ("3")) {
				MakeChoice (2);
			}
		}
	}
}
