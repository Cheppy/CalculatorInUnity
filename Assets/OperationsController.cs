using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperationsController : MonoBehaviour {
//[SerializeField] private InputField calcScreen;
private string operationName;
private float prevValue;
	// Use this for initialization
	public void Summator(InputField calcScreen) {
		if (calcScreen.text!=""){
		prevValue =float.Parse(calcScreen.text,
      								System.Globalization.CultureInfo.InvariantCulture);
		operationName = "+";
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
