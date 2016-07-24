using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tran : MonoBehaviour {
    public Image[] images;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    }
    public void showAll(int whoWon)
    {
        images[0].color = new Color(1, 1, 1, 1);
        images[1].color = new Color(1, 1, 1, 1);
        images[whoWon + 2].color = new Color(1, 1, 1, 1);
    }
}
