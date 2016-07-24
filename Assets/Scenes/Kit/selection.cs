using UnityEngine;
using UnityEngine.UI;
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

    //public Renderer[] MyRenderer;

    // Use this for initialization
    void Start () {

		m = GameObject.FindGameObjectWithTag ("Master").GetComponent<Master>();

        sound1 = GetComponent<AudioSource>();
        //Renderer1 = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        //character selection sequence
        if (Input.GetButtonDown("p1_Drop")) {
            charselect1 = 1; Debug.Log("dickbutt");
            sound1.Stop();
            sound1.clip = MyClips[0];
            sound1.Play();
            //GetComponent<Image>().color = new Color(1, 1, 1, 1);
            Images[12].color = new Color(1, 1, 1, 0);
            Images[8].color = new Color(1, 1, 1, 0);
            Images[4].color = new Color(1, 1, 1, 0);
            Images[0].color = new Color(1, 1, 1, 1);

			m.AssignDickbuttTo (1);
        }
        if (Input.GetButtonDown("p1_Bury")) {
            charselect1 = 3; Debug.Log("spaceship");
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
            charselect1 = 4; Debug.Log("girl");
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

			m.AssignDatBoiTo (1);

            charselect1 = 2; Debug.Log("question");
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

        //./
        //if (Input.GetButtonDown("p1_Zoom"))
        //{
        //  sound1.Stop();
        //}
        //if (Input.GetButtonDown("p1_Run"))
        //{
        //sound1.Stop();
        //sound1.clip = MyClips[4];
        //  sound1.Play();
        //}

    }
}
