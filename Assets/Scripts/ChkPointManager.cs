using UnityEngine;
using System.Collections;

public class ChkPointManager : MonoBehaviour {

	public GameObject[] Racers;
	private int totalPlayers;
	private GameObject[] checkPoints;
	private int totalPoints;

	private string pointName;

	private int[] playerPoints;
	private int[] playerLaps;
	private float[] distToNextPoint; // 1 - 4 dist to next point.
	private int[] playerPos;

	private float currPointDist;
	private float nextPointDist;

	private int nextPoint;
	private int currPoint;


	// Use this for initialization
	void Start () {

		playerPoints = new int[] { 0, 0, 0, 0 };
		playerLaps = new int[] { 1, 1, 1, 1 };
		distToNextPoint = new float[] { 0f, 0f, 0f, 0f };
		playerPos = new int[] { 0, 0, 0, 0 };

		pointName = "CheckPoint (";

		getAssignCheckpoints ();

		totalPlayers = 4;

	}
	
	// Update is called once per frame
	void Update () {

		updatePlayerPoints ();

		updateRacePositions ();

	}

	public int GetPlayerPos(int playerNum){
		return playerPos [playerNum];
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
			currPoint = playerPoints[i];
			nextPoint = playerPoints[i] + 1;

			currPointDist = (Racers [0].transform.position - checkPoints [currPoint%totalPoints].transform.position).magnitude;
			nextPointDist = (Racers [0].transform.position - checkPoints [nextPoint%totalPoints].transform.position).magnitude;

			if (nextPointDist < currPointDist) {
				//if closer to nextPoint, LEVEL UP!
				currPoint = nextPoint;
				if (nextPoint%totalPoints == 0) {
					playerLaps [i]++;
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
					if (playerPoints [i] > playerPoints [x])
						tempPos--;
					else if (distToNextPoint [i] < distToNextPoint [x] && playerPoints [i] == playerPoints [x]) {
						tempPos--;
					}		
				}
			}
			playerPos[i] = tempPos;
		}
	}
}
