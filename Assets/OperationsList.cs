using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Calculator
{
	public class OperationsList : MonoBehaviour {
		string OperationStored;

		public void OperationSignature(string operation)
		{
			OperationStored=operation;
		}
	}
	
}