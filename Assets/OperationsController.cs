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
	
	public void RE () 
	{
		calcScreen.text = "";
		prevValue = 0.0f;
	}
 
	public void OperationsCaller(int operation)
	{
			 switch(operation)
			 {
			 	case 1: Minus(); break;
			// 	case Plusle:  Plusle(); break;
			// 	case Dividor: Dividor(); break;
			
			}
	}
	
	public void Plusle()
	{

	}
	
	public void Dividor()
	{

	}

	public void Minus () 
	{ //Debug.Log(prevValue);
		 float onScreenValue = float.Parse (calcScreen.text,
										   System.Globalization.CultureInfo.InvariantCulture
										  );
		prevValue = onScreenValue;
		if (memory == 0) 
		{
			memory = prevValue;
			Debug.Log (memory);
		} 
		else 
		{
			memory = memory - prevValue;
			Debug.Log (memory);

		}
		calcScreen.text = "";
	}


}