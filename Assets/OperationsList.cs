using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Calculator
{	
	public class OperationsList : MonoBehaviour {
		public float result;

		public void Addition()
		{
			result=NumberInput.memoryValue+NumberInput.firstOperand;
			//return answer;
		}
		
	}
}