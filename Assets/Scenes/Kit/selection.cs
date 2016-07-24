using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class selection : MonoBehaviour {
    private int charselect1;
    private int charselect2;
    private int charselect3;
    private int charselect4;

    public Image[] Images;

	private Master m;

	private bool p1Chosen;
	private bool p2Chosen;
	private bool p3Chosen;
	private bool p4Chosen;

    // Use this for initialization
    void Start () {

		p1Chosen = false;
		p2Chosen = false;
		p3Chosen = false;
		p4Chosen = false;

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
			m.PlaySFX (4, 0);
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
			m.PlaySFX (3, 0);
            Images[12].color = new Color(1, 1, 1, 0);
            Images[8].color = new Color(1, 1, 1, 0);
            Images[4].color = new Color(1, 1, 1, 1);
            Images[0].color = new Color(1, 1, 1, 0);
        }
        if (Input.GetButtonDown("p2_Drop"))
		{
			p2Chosen = true;
			m.AssignDickbuttTo (2);
            charselect2 = 1;
			m.PlaySFX (0, 1);
            //GetComponent<Image>().color = new Color(1, 1, 1, 1);
            Images[13].color = new Color(1, 1, 1, 0);
            Images[9].color = new Color(1, 1, 1, 0);
            Images[5].color = new Color(1, 1, 1, 0);
            Images[1].color = new Color(1, 1, 1, 1);
        }
        if (Input.GetButtonDown("p2_Bury"))
		{
			p2Chosen = true;

			m.AssignSpaceshipTo (2);
            charselect2 = 3;
			m.PlaySFX (4, 1);
            //GetComponent<Image>().color = new Color(1, 1, 1, 1);
            Images[13].color = new Color(1, 1, 1, 0);
            Images[9].color = new Color(1, 1, 1, 1);
            Images[5].color = new Color(1, 1, 1, 0);
            Images[1].color = new Color(1, 1, 1, 0);
        }
        if (Input.GetButtonDown("p2_Jump"))
		{
			p2Chosen = true;

			m.AssignLittleGirlTo (2);
            charselect2 = 4;
			m.PlaySFX (1, 1);
            //GetComponent<Image>().color = new Color(1, 1, 1, 1);
            Images[13].color = new Color(1, 1, 1, 1);
            Images[9].color = new Color(1, 1, 1, 0);
            Images[5].color = new Color(1, 1, 1, 0);
            Images[1].color = new Color(1, 1, 1, 0);
        }
        if (Input.GetButtonDown("p2_Help"))
		{
			p2Chosen = true;

			m.AssignDatBoiTo (2);


            charselect2 = 2;
			m.PlaySFX (3, 1);
            //GetComponent<Image>().color = new Color(1, 1, 1, 1);
            Images[13].color = new Color(1, 1, 1, 0);
            Images[9].color = new Color(1, 1, 1, 0);
            Images[5].color = new Color(1, 1, 1, 1);
            Images[1].color = new Color(1, 1, 1, 0);
        }


        if (Input.GetButtonDown("p3_Drop"))
		{
			p3Chosen = true;

			m.AssignDickbuttTo (3);
            charselect3 = 1;
			m.PlaySFX (0, 2);
            //GetComponent<Image>().color = new Color(1, 1, 1, 1);
            Images[14].color = new Color(1, 1, 1, 0);
            Images[10].color = new Color(1, 1, 1, 0);
            Images[6].color = new Color(1, 1, 1, 0);
            Images[2].color = new Color(1, 1, 1, 1);
        }
        if (Input.GetButtonDown("p3_Bury"))
		{
			p3Chosen = true;

			m.AssignSpaceshipTo (3);

            charselect3 = 3;
			m.PlaySFX (4, 2);
            //GetComponent<Image>().color = new Color(1, 1, 1, 1);
            Images[14].color = new Color(1, 1, 1, 0);
            Images[10].color = new Color(1, 1, 1, 1);
            Images[6].color = new Color(1, 1, 1, 0);
            Images[2].color = new Color(1, 1, 1, 0);
        }
        if (Input.GetButtonDown("p3_Jump"))
		{
			p3Chosen = true;

			m.AssignLittleGirlTo (3);
            charselect3 = 4;
			m.PlaySFX (1, 2);
            //GetComponent<Image>().color = new Color(1, 1, 1, 1);
            Images[14].color = new Color(1, 1, 1, 4);
            Images[10].color = new Color(1, 1, 1, 0);
            Images[6].color = new Color(1, 1, 1, 0);
            Images[2].color = new Color(1, 1, 1, 0);
        }
        if (Input.GetButtonDown("p3_Help"))
		{
			p3Chosen = true;

			m.AssignDatBoiTo (3);


            charselect3 = 2;
			m.PlaySFX (3, 2);
            //GetComponent<Image>().color = new Color(1, 1, 1, 1);
            Images[14].color = new Color(1, 1, 1, 0);
            Images[10].color = new Color(1, 1, 1, 0);
            Images[6].color = new Color(1, 1, 1, 1);
            Images[2].color = new Color(1, 1, 1, 0);
        }

        if (Input.GetButtonDown("p4_Drop"))
		{
			p4Chosen = true;

			m.AssignDickbuttTo (4);
            charselect4 = 1;
			m.PlaySFX (0, 3);
            //GetComponent<Image>().color = new Color(1, 1, 1, 1);
            Images[15].color = new Color(1, 1, 1, 0);
            Images[11].color = new Color(1, 1, 1, 0);
            Images[7].color = new Color(1, 1, 1, 0);
            Images[3].color = new Color(1, 1, 1, 1);
        }
        if (Input.GetButtonDown("p4_Bury"))
		{
			p4Chosen = true;

			m.AssignSpaceshipTo (4);

            charselect4 = 3;
			m.PlaySFX (4, 3);
            //GetComponent<Image>().color = new Color(1, 1, 1, 1);
            Images[15].color = new Color(1, 1, 1, 0);
            Images[11].color = new Color(1, 1, 1, 1);
            Images[7].color = new Color(1, 1, 1, 0);
            Images[3].color = new Color(1, 1, 1, 0);
        }
        if (Input.GetButtonDown("p4_Jump"))
		{
			p4Chosen = true;

			m.AssignLittleGirlTo (4);
            charselect4 = 4;
			m.PlaySFX (1, 3);
            //GetComponent<Image>().color = new Color(1, 1, 1, 1);
            Images[15].color = new Color(1, 1, 1, 1);
            Images[11].color = new Color(1, 1, 1, 0);
            Images[7].color = new Color(1, 1, 1, 0);
            Images[3].color = new Color(1, 1, 1, 0);
        }
        if (Input.GetButtonDown("p4_Help"))
		{
			p4Chosen = true;

			m.AssignDatBoiTo (4);


            charselect4 = 2;
			m.PlaySFX (3, 3);
            //GetComponent<Image>().color = new Color(1, 1, 1, 1);
            Images[15].color = new Color(1, 1, 1, 0);
            Images[11].color = new Color(1, 1, 1, 0);
            Images[7].color = new Color(1, 1, 1, 1);
            Images[3].color = new Color(1, 1, 1, 0);
        }

		if (Input.GetButtonDown ("Start") && p1Chosen && p2Chosen && p3Chosen && p4Chosen) {
			SceneManager.LoadScene (2);
		}
    }
}
