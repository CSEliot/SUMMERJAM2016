using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class IntroScript : MonoBehaviour {

    public bool playFlag;
    public AudioSource introIntro;
    public AudioSource introLooped;

	private const int CHAR_SELECT_SCENE_NUM = 1;

	// Use this for initialization
	void Start ()
    {
        transform.parent.GetComponent<Animator>().Play(0);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (playFlag)
        {
            introIntro.Stop();
            introLooped.Play();
            playFlag = false;
        }

        if (Input.GetButton("p1_Jump") || Input.GetButton("p2_Jump") || Input.GetButton("p3_Jump") || Input.GetButton("p4_Jump"))
        {
            ClickPlay();
        }
	}

    public void ClickPlay()
    {
		SceneManager.LoadScene(CHAR_SELECT_SCENE_NUM);
    }
}
