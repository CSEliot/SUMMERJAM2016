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

    public Texture2D[] Images;

    //public Renderer[] MyRenderer;

    // Use this for initialization
    void Start () {
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
        }
        if (Input.GetButtonDown("p1_Bury")) {
            charselect1 = 3; Debug.Log("spaceship");
            sound1.Stop();
            sound1.clip = MyClips[3];
            sound1.Play();
        }
        if (Input.GetButtonDown("p1_Jump")) {
            charselect1 = 4; Debug.Log("girl");
            sound1.Stop();
            sound1.clip = MyClips[1];
            sound1.Play();
        }
        if (Input.GetButtonDown("p1_Help")) {
            charselect1 = 2; Debug.Log("question");
            sound1.Stop();
            sound1.clip = MyClips[2];
            sound1.Play();
        }

        if (Input.GetButtonDown("p2_Drop"))
        {
            charselect2 = 1;
        }
        if (Input.GetButtonDown("p2_Bury"))
        {
            charselect2 = 3;
        }
        if (Input.GetButtonDown("p2_Jump"))
        {
            charselect2 = 4;
        }
        if (Input.GetButtonDown("p2_Help"))
        {
            charselect2 = 2;
        }


        if (Input.GetButtonDown("p3_Drop"))
        {
            charselect3 = 1;
        }
        if (Input.GetButtonDown("p3_Bury"))
        {
            charselect3 = 3;
        }
        if (Input.GetButtonDown("p3_Jump"))
        {
            charselect3 = 4;
        }
        if (Input.GetButtonDown("p3_Help"))
        {
            charselect3 = 2;
        }

        if (Input.GetButtonDown("p4_Drop"))
        {
            charselect4 = 1;
        }
        if (Input.GetButtonDown("p4_Bury"))
        {
            charselect4 = 3;
        }
        if (Input.GetButtonDown("p4_Jump"))
        {
            charselect4 = 4;
        }
        if (Input.GetButtonDown("p4_Help"))
        {
            charselect4 = 2;
        }
        if (Input.GetButtonDown("p1_Zoom"))
        {
            sound1.Stop();
        }
        if (Input.GetButtonDown("p1_Run"))
        {
            sound1.Stop();
            sound1.clip = MyClips[4];
            sound1.Play();
        }

    }
}
