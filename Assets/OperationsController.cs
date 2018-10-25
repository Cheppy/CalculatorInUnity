using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Calculator{
	public class OperationsController : MonoBehaviour {
		[SerializeField] private InputField calcScreen;
		public static string operationName;
		
		public void RE () 
		{
			calcScreen.text = "";
			prevValue = 0.0f;
		}
 
		public void OperationsCaller(string operation)
		{
		 	switch (operation)
		 	{
		 		case "+": OperationListMinus();
				// 	case "-":
				// }
			}
	
	
	}
}