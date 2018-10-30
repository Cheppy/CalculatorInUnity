using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

namespace Calculator{


	public class NumbInput  {
		[SerializeField] private InputField calcScreen;
	    [SerializeField] private Button[] numbers;
		public  static float memoryValue;
		public static float firstOperand;
		public string opName="nan";
		
			public void onNumberButtonPress(int i){
			if (i>9)
				calcScreen.text=calcScreen.text+",";//TODO: or .
			else
			{
				int ij =Convert.ToInt32((numbers[i].name.ToString()));
				if ((numbers[ij].name).ToString() == ij.ToString())
			 		calcScreen.text=calcScreen.text+(numbers[ij].name).ToString();
			}
			memoryValue = float.Parse (calcScreen.text,
										   System.Globalization.CultureInfo.InvariantCulture
										  );			
		}	
		
	}
}