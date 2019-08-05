using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public static UIManager instace;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		UpdateTextScore(0);
		instace = this;
	}

	public void UpdateTextScore(int value){
		scoreText.text= value.ToString();
	}
}
