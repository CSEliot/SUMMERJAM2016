using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class IntroScript : MonoBehaviour {

    public bool playFlag;
    public AudioSource introIntro;
    public AudioSource introLooped;

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
	}

    public void ClickPlay()
    {
        SceneManager.LoadScene("Scenes/Kit/select", LoadSceneMode.Single);
    }
}
