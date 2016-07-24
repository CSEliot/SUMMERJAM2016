using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class credits : MonoBehaviour {
    public Text Text1;
    private AudioSource sound1;
    public AudioClip credit;

    // Use this for initialization
    void Start () {
        sound1 = GetComponent<AudioSource>();
        sound1.clip = credit;
        sound1.Play();
    }
	
	// Update is called once per frame
	void Update () {
        //Text1.rectTransform.anchoredPosition += Vector3.up * 10.0F;

    }
}
