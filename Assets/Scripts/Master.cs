using UnityEngine;
using System.Collections;

public class Master : MonoBehaviour {


	public enum Character{
		Dickbutt,
		Spaceship,
		LittleGirl,
		DatBoi
	};

	public AudioClip[] SFX;
	public AudioClip[] MSX;

	public AudioSource MSXBox;
	public AudioSource SFXBox;
	public AudioSource[] Announcers;

	private Character[] playerChars;

	private int currentWinner;

	// Use this for initialization
	void Start () {

		currentWinner = -1;

		if (GameObject.FindGameObjectsWithTag ("Master").Length > 1) {
			Destroy (gameObject);
		}

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

	public void PlaySFX(int sfxNum){
		SFXBox.Stop ();
		SFXBox.clip = SFX [sfxNum];
		SFXBox.Play ();
	}

	public void PlaySFX(int sfxNum, int announcerNum){
		Announcers [announcerNum].Stop ();
		Announcers [announcerNum].clip = SFX [sfxNum];
		Announcers [announcerNum].Play ();
	}

	public void PlayMSX(int msxNum){
		MSXBox.Stop ();
		MSXBox.clip = MSX [msxNum];
		MSXBox.Play ();
	}

	public void SetWinner(int playerNum){
		currentWinner = playerNum;
	}

	public int GetWinner(){
		return currentWinner;
	}
}
