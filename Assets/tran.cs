using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tran : MonoBehaviour {
    public Image[] images;

	private Master m;

	// Use this for initialization
	void Start () {
	
		m = GameObject.FindGameObjectWithTag ("Master").GetComponent<Master> ();

	}
	
	// Update is called once per frame
	void Update () {
    }
    public void showAll(int whoWon)
    {
        images[0].color = new Color(1, 1, 1, 1);
        images[1].color = new Color(1, 1, 1, 1);
		images[m.GetWinner() + 2].color = new Color(1, 1, 1, 1);
		StartCoroutine (endgameScreen());
    }

	private IEnumerator endgameScreen(){
		yield return new WaitForSeconds (3f);
		SceneManager.LoadScene ("theend");
	}
}
