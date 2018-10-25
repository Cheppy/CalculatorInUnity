using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Calculator{
public class OperationsController : MonoBehaviour {

	[SerializeField] private InputField calcScreen;
	public static string operationName;
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
			 	case 2:  Plusle(); break;
			// 	case Dividor: Dividor(); break;
			
			}
	}
	
	public void OperationsCaser(string operation)
	{
		 switch (operation)
		 {
		 	case "+": Minus();
		// 	case "-":
		// }
	}
	
	public void Plusle()
	{
		 float onScreenValue = float.Parse (calcScreen.text,
										   System.Globalization.CultureInfo.InvariantCulture
										   );
		prevValue = onScreenValue;
	
			memory = memory + onScreenValue;
			Debug.Log (memory);

		
		calcScreen.text = "";
	}
	
	public void Minus () 
	{ //Debug.Log(prevValue);
		operationName ="minus";

		
		calcScreen.text = "";
	}


}
}