using UnityEngine;
using System.Collections;

public class ShipControls : MonoBehaviour {

    bool fly;
    new Rigidbody rigidbody;
    float otherY;

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
            rigidbody.AddForce(Vector3.up * 10 * (1 - (transform.position.y - otherY)));
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.angularVelocity = Vector3.zero;
            if (Vector3.Dot(rigidbody.velocity, -transform.forward) < 30)
                rigidbody.AddForce(-transform.forward * 40);

        }
        if (Vector3.Dot(rigidbody.velocity, -transform.forward) > 30)
            rigidbody.velocity = rigidbody.velocity.normalized * 30;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * -3);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * 3);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Vector3.Dot(-rigidbody.velocity, -transform.forward) < 30)
                rigidbody.AddForce(transform.forward * 40);
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
