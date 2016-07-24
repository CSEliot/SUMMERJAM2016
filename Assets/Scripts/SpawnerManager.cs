using UnityEngine;
using System.Collections;

public class SpawnerManager : MonoBehaviour {

	private Master m;
	private ChkPointManager m_Chk;

	public GameObject[] RacerPrefabs;

	public Transform[] SpawnPoints;

	private GameObject[] playerObjs;

	private int totalPlayers;

	public int RespawnSleepTime = 3;
	private WaitForSeconds respawnClock;

	// Use this for initialization
	void Start () {

		respawnClock = new WaitForSeconds (3);

		totalPlayers = 4;

		playerObjs = new GameObject[4];
	
		m = GameObject.FindGameObjectWithTag ("Master").GetComponent<Master> ();
		m_Chk = GameObject.FindGameObjectWithTag ("CheckpointManager").GetComponent<ChkPointManager> ();

		for (int x = 0; x < totalPlayers; x++) {
			spawnPlayer (x);
		}
	}


	public IEnumerator RespawnPlayer(int playerNum){
		yield return respawnClock;
		GameObject Plr = Instantiate(RacerPrefabs[(int)m.GetPlayerChar(playerNum)], m_Chk.GetRespawnCheckpoint(playerNum), Quaternion.Euler(Vector3.zero)) as GameObject;
		Plr.GetComponentInChildren<Camera>().rect = new Rect((playerNum == 0 || playerNum == 2)? 0.0f : 0.5f, 
															  (playerNum == 2 || playerNum == 3)? 0.0f : 0.5f, 
															  0.5f, 
															  0.5f);
		
		Plr.name = "Player " + (playerNum + 1);

		playerObjs [playerNum] = Plr;

	}

	private void spawnPlayer(int playerNum){
		GameObject Plr = Instantiate(RacerPrefabs[(int)m.GetPlayerChar(playerNum)], SpawnPoints[playerNum].position, Quaternion.Euler(Vector3.zero)) as GameObject;
		Plr.GetComponentInChildren<Camera>().rect = new Rect((playerNum == 0 || playerNum == 2)? 0.0f : 0.5f, 
			(playerNum == 2 || playerNum == 3)? 0.0f : 0.5f, 
			0.5f, 
			0.5f);

		Plr.name = "Player " + (playerNum + 1);

		playerObjs [playerNum] = Plr;

	}
	
	// Update is called once per frame
	void Update () {

	}
}
