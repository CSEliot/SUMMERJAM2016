using UnityEngine;
using System.Collections;

public class anima : MonoBehaviour {
    private AudioSource sound1;
    public AudioClip aniSound;
    // Use this for initialization
    void Start () {
        sound1 = GetComponent<AudioSource>();
        sound1.clip = aniSound;
        sound1.Play();

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
