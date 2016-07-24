﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChkPointManager : MonoBehaviour {

	private GameObject[] racers;
	private Text[] racerLaps;
	private Text[] racerPlaces;

	private int totalPlayers;
	private GameObject[] checkPoints;
	private int totalPoints;

	private string pointName;

	private int[] playerPlace;
	private int[] playerLaps;
	private float[] distToNextPoint; // 1 - 4 dist to next point.
	private int[] playerPos;

	private float currPointDist;
	private float nextPointDist;

	private int nextPoint;
	private int currPoint;


	//DOES NOT SUPPORT GOING BACK!!!

	// Use this for initialization
	void Start () {

		racers = new GameObject[4];
		racerPlaces = new Text[4];
		racerLaps = new Text[4];

		playerPlace = new int[] { 0, 0, 0, 0 };
		playerLaps = new int[] { 1, 1, 1, 1 };
		distToNextPoint = new float[] { 0f, 0f, 0f, 0f };
		playerPos = new int[] { 0, 0, 0, 0 };

		pointName = "CheckPoint (";

		getAssignCheckpoints ();

		totalPlayers = 4;

		CorrectLookAhead ();
	}
	
	// Update is called once per frame
	void Update () {

		updatePlayerPoints ();

		updateRacePositions ();

	}

	public int GetPlayerPos(int playerNum){
		return playerPos [playerNum];
	}

	public int GetPlayerLap(int playerNum){
		return playerLaps [playerNum];
	}

	public Transform GetRespawnCheckpoint(int playerNum){
		return checkPoints[playerPlace[playerNum]].transform;
	}

	public void AssignNewTracking(GameObject newTracker, int playerNum){
		racers[playerNum] = newTracker;
		racerPlaces[playerNum] = newTracker.GetComponent<ShipControls> ().Place;
		racerLaps [playerNum] = newTracker.GetComponent<ShipControls> ().Lap;
	}

	private void CorrectLookAhead(){
		for (int i = 0; i < checkPoints.Length; i++) {
			checkPoints [i % checkPoints.Length].transform.LookAt (checkPoints [(i + 1) % checkPoints.Length].transform.position);
		}
	}

	private void getAssignCheckpoints(){
		GameObject[] tempObjs = GameObject.FindGameObjectsWithTag ("CheckPoints");
		checkPoints = new GameObject[tempObjs.Length];
		for (int i = 0; i < checkPoints.Length; i++) {
			for (int x = 0; x < tempObjs.Length; x++) {
				if (tempObjs [x].name == (pointName + i + ")")) {
					checkPoints [i] = tempObjs [x];
				}
			}
		}
		totalPoints = tempObjs.Length;
	}

	private void updatePlayerPoints(){
		for (int i = 0; i < totalPlayers; i++) {
			currPoint = playerPlace[i];
			nextPoint = playerPlace[i] + 1;

			currPointDist = (racers [i].transform.position - checkPoints [currPoint%totalPoints].transform.position).magnitude;
			nextPointDist = (racers [i].transform.position - checkPoints [nextPoint%totalPoints].transform.position).magnitude;

			if (nextPointDist < currPointDist) {
				//if closer to nextPoint, LEVEL UP!
				playerPlace[i] = nextPoint;


				if (nextPoint%totalPoints == 0) {
					playerLaps [i]++;
					racerLaps [i].text = ""+playerLaps [i];
				}
			}

			distToNextPoint[i] = nextPointDist; // used for update Race Position

		}
	}

	private void updateRacePositions(){
		for (int i = 0; i < totalPlayers; i++) {
			int tempPos = 4;
			for (int x = 0; x < totalPlayers; x++) {
				if (x != i) {
					if (playerPlace [i] > playerPlace [x])
						tempPos--;
					else if (distToNextPoint [i] < distToNextPoint [x] && playerPlace [i] == playerPlace [x]) {
						tempPos--;
					}		
				}
			}
			playerPos[i] = tempPos;
			racerPlaces [i].text = "" + tempPos;
		}
	}

}
