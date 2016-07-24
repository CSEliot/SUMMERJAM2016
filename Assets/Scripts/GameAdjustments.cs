using UnityEngine;
using System.Collections;

public class GameAdjustments : MonoBehaviour {

	// Use this for initialization
	void Start () {
		adjustRotations ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void adjustRotations(){
		
		if (transform.GetChild (0).name.Contains ("Ship")) {
			Quaternion tempQ = Quaternion.Euler (new Vector3 (0, 180f, 0));
			transform.localRotation.Set (tempQ.x, tempQ.y, tempQ.z, tempQ.w);
		}
		transform.GetChild (0).transform.parent = null;
	}
}
