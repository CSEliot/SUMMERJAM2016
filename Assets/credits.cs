﻿using UnityEngine;
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

    // Use this for initialization
    void Start()
    {
        sound1 = GetComponent<AudioSource>();
        sound1.clip = credit;
        sound1.Play();
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
                sound2 = GetComponent<AudioSource>();
                sound1.Stop();
                sound2.Stop();
                sound2.clip = curby;
                sound2.Play();
            }

        }
    }
}
