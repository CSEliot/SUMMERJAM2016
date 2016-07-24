using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{
	void Start ()
    {
        var exp = GetComponent<ParticleSystem>();
        exp.Play();
        Destroy(this, exp.duration);
    }
}
