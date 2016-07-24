using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class credits : MonoBehaviour
{
    public Text Text1;
    public AudioSource sound1;
    public AudioSource sound2;
    private int curb = 0;
    public AudioClip credit;
    public AudioClip curby;

	private Master m;

    // Use this for initialization
    void Start()
    {

		m = GameObject.FindGameObjectWithTag ("Master").GetComponent<Master> ();

        m.PlayMSX(4);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            //Text1.rectTransform.anchoredPosition += Vector3.up * 10.0F;
            curb += 1;
            if (curb == 3)
            {
				m.PlayMSX (5);
            }

        }
    }
}
