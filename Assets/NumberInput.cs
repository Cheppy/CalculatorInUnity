using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class NumberInput : MonoBehaviour {
	[SerializeField] private InputField calcScreen;
	[SerializeField] private Button[] numbers;


	// Use this for initialization
	void Start () {
		
	}

	public void onNumberButtonPress(int i){
		//sint i = 
	int ij =Convert.ToInt32((numbers[i].name.ToString()));
	if ((numbers[ij].name).ToString()== ij.ToString())
			 	calcScreen.text=calcScreen.text+(numbers[ij].name).ToString();
			 //	Debug.Log(i);
							}
		
}
