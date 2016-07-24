using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class stageselect : MonoBehaviour {
    private AudioSource sound1;
    private float timeLeft = 1;
    private bool gonow = false;
    public AudioClip selectSound;
    public Image[] Images;
    // Use this for initialization
    void Start () {
        Debug.Log("faaab");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("p1_Help"))
        {
            SceneManager.LoadScene("theend");
        }
            if (!(Input.GetButtonDown("p1_Help")) && (Input.anyKeyDown))
        {
            sound1 = GetComponent<AudioSource>();
            sound1.clip = selectSound;
            sound1.Play();
            for (int n = 0; n < 3; n += 1)
            {
                Images[n].color = new Color(1, 1, 1, 1);
                gonow = true;
                Debug.Log("sofarsogood!");
            }
        }
            if (gonow == true) {
                Debug.Log("wtf");
                timeLeft -= Time.deltaTime;
                if (timeLeft < 0)
                {
                    Debug.Log("work");
                    SceneManager.LoadScene("Map_1");
                    
                }
            }
    }
}
