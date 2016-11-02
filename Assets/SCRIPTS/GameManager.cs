using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	bool saidOKToFish;

	// Use this for initialization
	void Start () {
		saidOKToFish = false;
	}


	public void RecordSaidOkToFish () {
		saidOKToFish = true;
	}

	public bool SaidOkToFish { get { return saidOKToFish; } }
	
	// Update is called once per frame
	void Update () {
	
	}
}
