using UnityEngine;
using System.Collections;


public class Choice {
	string choiceText;
	Dialogue potentialDialogue;
	bool saidOkToFish;

	public Choice (string c, Dialogue d, bool saidOkToFish) {
		choiceText = c;
		potentialDialogue = d;
		this.saidOkToFish = saidOkToFish;
	}

	public string Text { get { return choiceText; } }
	public Dialogue NexDialogue { get { return potentialDialogue; } }
	public bool SaidOKToFish { get { return saidOkToFish; } }

}


public class Dialogue {

	string text;
	Choice[] choices;
	
	public Dialogue (string text, Choice[] choices) {
		this.text = text;
		this.choices = choices;
	}

	public string Text { get { return text; } }
	public Choice[] Choices { get { return choices; } } 
}