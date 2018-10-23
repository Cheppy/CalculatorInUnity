﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class NumberInput : MonoBehaviour {
	[SerializeField] private InputField calcScreen;
	[SerializeField] private Button[] numbers;


	// Use this for initialization
	
	public void onNumberButtonPress(int i){
		if (i>9)
			calcScreen.text=calcScreen.text+",";//TODO: or .
		else{
			int ij =Convert.ToInt32((numbers[i].name.ToString()));
			if ((numbers[ij].name).ToString()== ij.ToString())
			 	calcScreen.text=calcScreen.text+(numbers[ij].name).ToString();
			}
			 //Debug.Log(3);
	}
		
}
