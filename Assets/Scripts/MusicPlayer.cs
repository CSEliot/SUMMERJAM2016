using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	private Master m;

	// Use this for initialization
	void Start () {
		
		m = GameObject.FindGameObjectWithTag ("Master").GetComponent<Master> ();

		m.PlayMSX (Random.Range (0, 2));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
