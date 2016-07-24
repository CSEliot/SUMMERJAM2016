using UnityEngine;
using System.Collections;

public class Master : MonoBehaviour {


	public enum Character{
		Dickbutt,
		Spaceship,
		LittleGirl,
		DatBoi
	};

	private Character[] playerChars;

	// Use this for initialization
	void Start () {

		playerChars = new Character[4];
	
		DontDestroyOnLoad (gameObject);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AssignLittleGirlTo(int player){

		Debug.Log ("Assigning Little Girl to Player: " + player);

		playerChars [player-1] = Character.LittleGirl;
	}

	public void AssignSpaceshipTo(int player){

		Debug.Log ("Assigning Spaceship to Player: " + player);

		playerChars [player-1] = Character.Spaceship;
	}

	public void AssignDickbuttTo(int player){

		Debug.Log ("Assigning Dickbutt to Player: " + player);

		playerChars [player-1] = Character.Dickbutt;
	}

	public void AssignDatBoiTo(int player){

		Debug.Log ("Assigning DatBoi to Player: " + player);

		playerChars [player-1] = Character.DatBoi;
	}

	public Character GetPlayerChar(int player){
		return playerChars [player];
	}
}
