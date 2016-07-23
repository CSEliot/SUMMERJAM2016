using UnityEngine;
using System.Collections;

public class ShipControls : MonoBehaviour {

    bool fly;
    new Rigidbody rigidbody;
    float otherY;

    public float ForceScale = 1f;
    public float MaxSpeed = 30;
    public float Acceleration = 40;
    public float TurnRate = 3;

	// Use this for initialization
	void Start ()
    {
        fly = false;
        rigidbody = GetComponent<Rigidbody>();
        otherY = 0;
    }

    // Update is called once per frame
    void Update ()
    {
        if (fly)
        {
            rigidbody.AddForce(-Physics.gravity);
            rigidbody.AddForce(Vector3.up * 10 * (1 - (transform.position.y - otherY)) * ForceScale);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.angularVelocity = Vector3.zero;
            if (Vector3.Dot(rigidbody.velocity, -transform.forward) < MaxSpeed)
                rigidbody.AddForce(-transform.forward * Acceleration * ForceScale);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Vector3.Dot(-rigidbody.velocity, -transform.forward) < MaxSpeed)
                rigidbody.AddForce(transform.forward * Acceleration * ForceScale);
        }
        else
        {
            rigidbody.velocity *= 0.99f;
        }
        if (Vector3.Dot(rigidbody.velocity, -transform.forward) > MaxSpeed)
            rigidbody.velocity = rigidbody.velocity.normalized * MaxSpeed;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * -TurnRate);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * TurnRate);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            // TODO: Powerup
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            fly = true;
            otherY = other.transform.position.y;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            fly = false;
            otherY = other.transform.position.y;
        }
    }
}
