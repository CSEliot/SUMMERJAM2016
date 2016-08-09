using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class selection : MonoBehaviour {
    private int charselect1;

    public Image[] Images;

	private Master m;

	private bool p1Chosen;

    // Use this for initialization
    void Start () {

		p1Chosen = false;

		m = GameObject.FindGameObjectWithTag ("Master").GetComponent<Master>();
        m.PlayMSX(2);
    }


	// Update is called once per frame
	void Update () {
        //character selection sequence
        if (Input.GetButtonDown("p1_Drop")) {

			p1Chosen = true;

			m.AssignDickbuttTo (1);
			m.PlaySFX (0, 0);
            charselect1 = 1; 
            //GetComponent<Image>().color = new Color(1, 1, 1, 1);
            Images[12].color = new Color(1, 1, 1, 0);
            Images[8].color = new Color(1, 1, 1, 0);
            Images[4].color = new Color(1, 1, 1, 0);
            Images[0].color = new Color(1, 1, 1, 1);

        }
		if (Input.GetButtonDown("p1_Bury")) {
			p1Chosen = true;
            charselect1 = 3;
			m.AssignSpaceshipTo (1);
			m.PlaySFX (3, 0);
            Images[12].color = new Color(1, 1, 1, 0);
            Images[8].color = new Color(1, 1, 1, 1);
            Images[4].color = new Color(1, 1, 1, 0);
            Images[0].color = new Color(1, 1, 1, 0);
        }
		if (Input.GetButtonDown("p1_Jump")) {
			p1Chosen = true;
            charselect1 = 4; 
			m.AssignLittleGirlTo (1);
			m.PlaySFX (1, 0);
            Images[12].color = new Color(1, 1, 1, 1);
            Images[8].color = new Color(1, 1, 1, 0);
            Images[4].color = new Color(1, 1, 1, 0);
            Images[0].color = new Color(1, 1, 1, 0);
        }
		if (Input.GetButtonDown("p1_Help")) {
			p1Chosen = true;

			m.AssignDatBoiTo (1);

            charselect1 = 2; 
			m.PlaySFX (2, 0);
            Images[12].color = new Color(1, 1, 1, 0);
            Images[8].color = new Color(1, 1, 1, 0);
            Images[4].color = new Color(1, 1, 1, 1);
            Images[0].color = new Color(1, 1, 1, 0);
        }

		if (Input.GetButtonDown ("Start") && p1Chosen) {
			SceneManager.LoadScene ("stage select");
		}
    }
}
