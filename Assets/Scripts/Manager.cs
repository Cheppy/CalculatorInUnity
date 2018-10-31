using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
	public class Manager : MonoBehaviour {

		public VerticalLayoutGroup buttonGroup;
		public HorizontalLayoutGroup bottomRow;
		public RectTransform canvasRect;
		OperationsList op;
		CalcButton[] bottomButtons;
		public Text digitLabel;
		public Text operatorLabel;
		bool errorDisplayed;
		bool displayValid;
		float currentVal;
		float storedVal;
		float result;
		char storedOperator;

		bool canvasChanged;

		private void Awake()
		{
			bottomButtons = bottomRow.GetComponentsInChildren<CalcButton>();
		}


		// Use this for initialization
		void Start () {
			bottomRow.childControlWidth = false;
			canvasChanged = true;
			buttonTapped('c');
		}
		
		// Update is called once per frame
		void Update () {
			if (canvasChanged)
			{
				canvasChanged = false;
				adjustButtons();
			}
			
		}

		private void OnRectTransformDimensionsChange()
		{
			canvasChanged = true;
		}

		void adjustButtons()
		{
			if (bottomButtons == null || bottomButtons.Length == 0)
				return;
			float buttonSize = canvasRect.sizeDelta.x / 4;
			float bWidth = buttonSize - bottomRow.spacing;
			for (int i = 1; i < bottomButtons.Length;i++)
			{
				bottomButtons[i].rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,
																		bWidth);
			}
			bottomButtons[0].rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,
																	bWidth * 2 + bottomRow.spacing);
		}

		void RE()
		{
			digitLabel.text = "0";
			operatorLabel.text = "";
			currentVal = result = storedVal = 0;
			storedOperator = ' ';
		}
		void updateScreen()
		{
			if (!errorDisplayed)
				digitLabel.text = currentVal.ToString();
			displayValid = false;
		}



		

		void calcResult(char operationName)
		{	
			switch (operationName)
			{
				case '=':
					result = currentVal;
					break;
				case '+':
					op.Sum(storedVal, currentVal);
					break;
				case '-':
					op.Sub(storedVal, currentVal);
					break;
				case 'x':
					op.Mult(storedVal, currentVal);
					break;
				case '÷':
					if (currentVal!=0)
					{
						op.Div(storedVal, currentVal);
					}
					else
					{
						errorDisplayed = true;
						digitLabel.text = "ERROR";
					}
					break;
			}
			currentVal = result;
			updateScreen();
		}

		public void buttonTapped(char caption)
		{
			if (errorDisplayed)
				RE();

			if ((caption>='0' && caption<='9')||caption=='.')
			{
				if (digitLabel.text.Length<15 || !displayValid)
				{
					if (!displayValid)
						digitLabel.text = (caption == '.' ? "0" : "");
					else if (digitLabel.text == "0" && caption != '.')
						digitLabel.text = "";
					digitLabel.text += caption;
					displayValid = true;
				}
			}
			else if (caption=='C')
			{
				RE();
			}
			else if (caption == '±')
			{
				currentVal = -1*float.Parse(digitLabel.text);
				updateScreen();
			}
			else if (caption == '%')
			{
				currentVal = float.Parse(digitLabel.text) / 100.0f;
				updateScreen();
			}
			else if (displayValid || storedOperator == '=')
			{
				currentVal = float.Parse(digitLabel.text);
				displayValid = false;
				if (storedOperator!=' ')
				{
					calcResult(storedOperator);
					storedOperator = ' ';
				}
				operatorLabel.text = caption.ToString();
				storedOperator = caption;
				storedVal = currentVal;
				updateScreen();
			}
		}
	}
