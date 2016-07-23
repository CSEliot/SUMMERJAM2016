using UnityEngine;
using System.Collections;

public class ShipControls : MonoBehaviour {

    new Rigidbody rigidbody;

	// Use this for initialization
	void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        RaycastHit[] hits = Physics.BoxCastAll(transform.position + new Vector3(0, 0.4f, -3), new Vector3(2f, 1f, 4f), -Vector3.up);
        foreach (RaycastHit r in hits)
        {
            if (r.distance < 1f && !r.collider.gameObject.CompareTag("Player"))
            {
                Debug.Log(r.collider.gameObject);
                rigidbody.AddForce(Vector3.up * 30);
            }
        }
    }
}
