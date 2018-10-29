using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Calculator {
	public class OperationsController  {
		OperationsList operationsList = new OperationsList();
		public  string operationName="none";
		public  void OperationCaller(string operation)
		{	
			switch (operation)
			{
				case "+": operationsList.Addition(); break;
			    case "-": operationsList.Sub(); break;

			}
		}
   }
}