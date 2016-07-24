using UnityEngine;
using System.Collections;

public class GameAdjustments : MonoBehaviour {

	private bool isAdjusted;
	private bool isUnparented;

	// Use this for initialization
	void Start () {

		isAdjusted = false;
		isUnparented = false;

	}
	
	// Update is called once per frame
	void Update () {
		adjustRotations ();

		if (isAdjusted && !isUnparented) {
			transform.GetChild (0).transform.parent = null;
			isUnparented = true;
		}
	}

	private void adjustRotations(){

		if (isAdjusted)
			return;

		isAdjusted = true;

		Master.Character tempChar = transform.GetChild (0).GetComponent<ShipControls> ().myChar;

		if (tempChar == Master.Character.Spaceship || tempChar == Master.Character.DatBoi) {
			transform.GetChild (0).transform.Rotate(new Vector3(0f, 180f, 0f));
		}

	}
}
