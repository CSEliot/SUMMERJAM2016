using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class selection : MonoBehaviour {
    private int charselect1;
    private int charselect2;
    private int charselect3;
    private int charselect4;

    private AudioSource sound1;

    //private Renderer Renderer1;

    public AudioClip[] MyClips;

    public Image[] Images;

	private Master m;

	private bool p1Chosen;
	private bool p2Chosen;
	private bool p3Chosen;
	private bool p4Chosen;

    //public Renderer[] MyRenderer;

    // Use this for initialization
    void Start () {

		p1Chosen = false;
		p2Chosen = false;
		p3Chosen = false;
		p4Chosen = false;

		m = GameObject.FindGameObjectWithTag ("Master").GetComponent<Master>();

        sound1 = GetComponent<AudioSource>();
        //Renderer1 = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        //character selection sequence
        if (Input.GetButtonDown("p1_Drop")) {

			p1Chosen = true;

			m.AssignDickbuttTo (1);
            charselect1 = 1; 
            sound1.Stop();
            sound1.clip = MyClips[0];
            sound1.Play();
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
            sound1.Stop();
            sound1.clip = MyClips[3];
            sound1.Play();
            Images[12].color = new Color(1, 1, 1, 0);
            Images[8].color = new Color(1, 1, 1, 1);
            Images[4].color = new Color(1, 1, 1, 0);
            Images[0].color = new Color(1, 1, 1, 0);
        }
		if (Input.GetButtonDown("p1_Jump")) {
			p1Chosen = true;
            charselect1 = 4; 
			m.AssignLittleGirlTo (1);
            sound1.Stop();
            sound1.clip = MyClips[1];
            sound1.Play();
            Images[12].color = new Color(1, 1, 1, 1);
            Images[8].color = new Color(1, 1, 1, 0);
            Images[4].color = new Color(1, 1, 1, 0);
            Images[0].color = new Color(1, 1, 1, 0);
        }
		if (Input.GetButtonDown("p1_Help")) {
			p1Chosen = true;

			m.AssignDatBoiTo (1);

            charselect1 = 2; 
            sound1.Stop();
            sound1.clip = MyClips[2];
            sound1.Play();
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
            sound1.Stop();
            sound1.clip = MyClips[0];
            sound1.Play();
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
            sound1.Stop();
            sound1.clip = MyClips[3];
            sound1.Play();
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
            sound1.Stop();
            sound1.clip = MyClips[1];
            sound1.Play();
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
            sound1.Stop();
            sound1.clip = MyClips[2];
            sound1.Play();
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
            sound1.Stop();
            sound1.clip = MyClips[0];
            sound1.Play();
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
            sound1.Stop();
            sound1.clip = MyClips[3];
            sound1.Play();
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
            sound1.Stop();
            sound1.clip = MyClips[1];
            sound1.Play();
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
            sound1.Stop();
            sound1.clip = MyClips[2];
            sound1.Play();
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
            sound1.Stop();
            sound1.clip = MyClips[0];
            sound1.Play();
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
            sound1.Stop();
            sound1.clip = MyClips[3];
            sound1.Play();
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
            sound1.Stop();
            sound1.clip = MyClips[1];
            sound1.Play();
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
            sound1.Stop();
            sound1.clip = MyClips[2];
            sound1.Play();
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
