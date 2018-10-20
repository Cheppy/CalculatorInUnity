using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperationsController : MonoBehaviour {
//[SerializeField] private InputField calcScreen;
private string operationName;
private float prevValue=0.0f;
private bool ifOpPressed=false;
	// Use this for initialization
	public void Summator(InputField calcScreen) {
		//ifOpPressed=false;
		if  (calcScreen.text!=""){
			prevValue =prevValue+float.Parse(calcScreen.text,
      								System.Globalization.CultureInfo.InvariantCulture);
			operationName = "+";
			ifOpPressed = true;
		}
		else 
			prevValue=0;
		calcScreen.text="";
		Debug.Log(prevValue);	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
