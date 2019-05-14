using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager singleton; //object only exists once

	private GroundPiece[] allGroundPieces;


	// Use this for initialization
	void Start () {
			SettupNewLevel();
	}
	private void SettupNewLevel()
	{
		allGroundPieces = FindObjectsOfType<GroundPiece>();	//im going to check in all the scene if theres a type groundpiece
	}
}
