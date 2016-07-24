using UnityEngine;
using System.Collections;

public class Powerup : MonoBehaviour {

    private HingeJoint joint;
    private float downTime;

	// Use this for initialization
	void Start ()
    {
        joint = GetComponent<HingeJoint>();
        joint.anchor = new Vector3(0f, -0.5f, 0f);
        joint.axis = transform.right;
        joint.connectedAnchor = transform.position - Vector3.up;
        joint.useSpring = false;
        JointSpring spring = joint.spring;
        spring.targetPosition = 0;
        spring.spring = 100;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!joint.useSpring)
        {
            downTime -= Time.deltaTime;
            if (downTime <= 0f)
            {
                joint.useSpring = true;
            }
        }
	}
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("O shit waddup");
            GameObject temp = other.gameObject;
            while (temp.GetComponent<ShipControls>() == null)
                temp = temp.transform.parent.gameObject;
            Debug.Log(temp.name);
            temp.GetComponent<ShipControls>().GetPowerup();
            downTime = 4f;
            joint.useSpring = false;
        }
    }
}
