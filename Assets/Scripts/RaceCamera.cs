using UnityEngine;
using System.Collections;

public class RaceCamera : MonoBehaviour {

    public GameObject Target;
    public float MaxDistance;

    private Vector3 Velocity;
    new Transform transform;
    private Transform targetTransform;

    // Use this for initialization
    void Start ()
    {
        transform = GetComponent<Transform>();
        targetTransform = Target.GetComponent<Transform>();
        Velocity = Vector3.zero;
        MaxDistance = 20;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(Velocity);

        transform.LookAt(targetTransform);
        Vector3 posDiff = targetTransform.position - transform.position;
        Vector3 towards = posDiff.x * Vector3.right + posDiff.z * Vector3.forward;

        if (posDiff.sqrMagnitude > MaxDistance * MaxDistance)
        {
            Velocity += towards.normalized;
        }
        else if (posDiff.sqrMagnitude < MaxDistance * MaxDistance - 5)
        {
            Velocity *= 0.9f;
        }
           
        transform.position += Velocity * Time.deltaTime;
	}
}
