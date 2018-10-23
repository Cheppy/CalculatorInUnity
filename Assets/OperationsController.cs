using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperationsController : MonoBehaviour {
	//[SerializeField] private InputField calcScreen;
	private string operationName;
	private float prevValue;
	private bool ifOpPressed = false;
	//this section is all about monkeycode. TODO: make this part pretty like princess kenny
	private bool ifMinusPressed = false;
	// Use this for initialization
	public void RE (InputField calcScreen) {
		calcScreen.text = "";
		prevValue = 0.0f;
		ifMinusPressed = false;
	}

	public void Summator (InputField calcScreen) {
		//ifOpPressed=false;
		if (calcScreen.text != "") {
			prevValue = prevValue + float.Parse (calcScreen.text,
												System.Globalization.CultureInfo.InvariantCulture
												);
			operationName = "+";

		} 
		else
			prevValue = 0;
		calcScreen.text = "";
		Debug.Log (prevValue);
	}
	public void Minussator (InputField calcScreen) {
		//ifOpPressed=false;

		if (calcScreen.text != "") {
			prevValue = prevValue - float.Parse (calcScreen.text,
												 System.Globalization.CultureInfo.InvariantCulture
												);
			operationName = "-";

		} 
		else
			prevValue = 0.0f;
		calcScreen.text = "";
		Debug.Log (prevValue);
	}

	public void Multiplator (InputField calcScreen) {
		//ifOpPressed=false;
		if (calcScreen.text != "") {
			prevValue = prevValue * float.Parse (calcScreen.text,
												 System.Globalization.CultureInfo.InvariantCulture
												);
			operationName = "*";

		} 
		else
			prevValue = 0;
		calcScreen.text = "";

		Debug.Log (prevValue);
	}
	public void Divator (InputField calcScreen) {
		//ifOpPressed=false;
		if (calcScreen.text != "") {
			if (prevValue != 0) {
				prevValue = prevValue / float.Parse (calcScreen.text,
					System.Globalization.CultureInfo.InvariantCulture);
				operationName = "/";
			} 
			else calcScreen.text = "ERRROR %%00 PRESS RE";

		} 
		else
			prevValue = 0;
		calcScreen.text = "";

		Debug.Log (prevValue);
	}

	// Update is called once per frame
	void Start () {
		Debug.Log (ifMinusPressed);
	}
}