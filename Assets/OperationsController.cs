using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperationsController : MonoBehaviour {
	[SerializeField] private InputField calcScreen;
	private string operationName;
	private float prevValue;
	private float secondOp;
	private float memory;
	private bool ifOpPressed = false;
	//private InputField calcScreen;
	//this section is all about monkeycode. TODO: make this part pretty like princess kenny
	private bool ifMinusPressed = false;
	//string operation;
	// Use this for initialization
	public void RE () {
		//calcScreen.text = "";
		prevValue = 0.0f;
		ifMinusPressed = false;
	}
	public void Operations(int operation)
	{
		switch(operation)
		{
			case 1:  Minus(); break;
		 
		}
	}
	public void Minus () { //Debug.Log(prevValue);
		float onScreenValue = float.Parse (calcScreen.text,
										   System.Globalization.CultureInfo.InvariantCulture
										  );
		prevValue = onScreenValue;
		if (memory == 0) {
			memory = prevValue;
			Debug.Log (memory);
		} else {
			memory = memory - prevValue;
			Debug.Log (memory);

		}
		calcScreen.text = "";
	}


}