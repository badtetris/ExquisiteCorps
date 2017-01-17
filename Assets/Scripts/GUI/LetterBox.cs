﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterBox : MonoBehaviour {

	public SpriteRenderer topSquare, rightSquare, bottomSquare, leftSquare;

	public void activateLetterBox(float top, float right, float bottom, float left) {

		float screenRight = Camera.main.orthographicSize*Camera.main.aspect;
		float screenLeft = -screenRight;
		float screenTop = Camera.main.orthographicSize;
		float screenBottom = -screenTop;

		float topYScale = screenTop - top;
		float rightXScale = screenRight - right;
		float bottomYScale = bottom - screenBottom;
		float leftXScale = left - screenLeft;

		transform.localPosition = new Vector3(0, 0, transform.localPosition.z);

		topSquare.transform.position = new Vector3(0, top, topSquare.transform.position.z);
		rightSquare.transform.position = new Vector3(right, 0, rightSquare.transform.position.z);
		bottomSquare.transform.position = new Vector3(0, bottom, bottomSquare.transform.position.z);
		leftSquare.transform.position = new Vector3(left, 0, leftSquare.transform.position.z);

		float verticalWidth = right-left;
		float horizontalHeight = 2*screenTop;

		topSquare.transform.localScale = new Vector3(verticalWidth, topYScale, 1);
		rightSquare.transform.localScale = new Vector3(rightXScale, horizontalHeight, 1);
		bottomSquare.transform.localScale = new Vector3(verticalWidth, bottomYScale, 1);
		leftSquare.transform.localScale = new Vector3(leftXScale, horizontalHeight, 1);

		topSquare.enabled = true;
		rightSquare.enabled = true;
		bottomSquare.enabled = true;
		leftSquare.enabled = true;
	}


}
