using UnityEngine;
using System.Collections;

public class ShipControls : MonoBehaviour {

    bool fly;
    new Rigidbody rigidbody;
    float otherY;

    public float ForceScale = 1f;
    public float MaxSpeed = 30;
    public float BoostBonusSpeed = 30;
    public float BoostBonusAccel = 10;
    public float CollisionBonusSpeed = 10;
    public float Acceleration = 40;
    public float TurnRate = 3;
    public bool IsDickbutt = false;
    public EPowerUp powerup = EPowerUp.None;
    public float CollisionPupTime = -1f;
    public float BoostTime = -1f;

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
        if (CollisionPupTime >= 0)
        {
            // TODO: Fancy effect
            CollisionPupTime -= Time.deltaTime;
            if (CollisionPupTime < 0)
                MaxSpeed -= CollisionBonusSpeed;
        }

        if (BoostTime >= 0)
        {
            // TODO: Fancy effect
            BoostTime -= Time.deltaTime;
            if (BoostTime < 0)
            {
                MaxSpeed -= BoostBonusSpeed;
                Acceleration -= BoostBonusAccel;
            }
        }

        if (fly)
        {
            rigidbody.AddForce(-Physics.gravity);
            rigidbody.AddForce(Vector3.up * 10 * (1 - (transform.position.y - otherY)) * ForceScale);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.angularVelocity = Vector3.zero;
            if (Mathf.Abs(Vector3.Dot(rigidbody.velocity, -transform.forward)) < MaxSpeed)
                rigidbody.AddForce((IsDickbutt ? -transform.up : -transform.forward) * Acceleration * ForceScale);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Mathf.Abs(Vector3.Dot(-rigidbody.velocity, -transform.forward)) < MaxSpeed)
                rigidbody.AddForce((IsDickbutt ? transform.up : transform.forward) * Acceleration * ForceScale);
        }
        else
        {
            rigidbody.velocity *= 0.99f;
        }
        if (Vector3.Dot(rigidbody.velocity, -transform.forward) > MaxSpeed)
            rigidbody.velocity = rigidbody.velocity.normalized * MaxSpeed;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate((IsDickbutt ? -Vector3.right : Vector3.up) * -TurnRate);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate((IsDickbutt ? -Vector3.right : Vector3.up) * TurnRate);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            UsePowerup();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        // Collect powerup
        if (other.gameObject.CompareTag("Powerup"))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    powerup = EPowerUp.Boost;
                    break;
                case 2:
                    powerup = EPowerUp.Collision;
                    break;
                case 3:
                    powerup = EPowerUp.Projectile;
                    break;
                default:
                    powerup = EPowerUp.None;
                    break;
            }
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            if (CollisionPupTime > 0)
            {
                // TODO: rek other person running into you
            }
        }
    }

    void UsePowerup()
    {
        switch (powerup)
        {
            case EPowerUp.Boost:
                BoostTime = 1f;
                MaxSpeed += BoostBonusSpeed;
                Acceleration += BoostBonusAccel;
                break;
            case EPowerUp.Collision:
                CollisionPupTime = 7f;
                MaxSpeed += CollisionBonusSpeed;
                break;
            case EPowerUp.Projectile:
                // TODO: Spawn projectile
                break;
            case EPowerUp.None:
                // You don't have a powerup ya dingus
                break;
        }
        powerup = EPowerUp.None;
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


    public enum EPowerUp
    {
        None,
        Boost,
        Collision,
        Projectile
    }
}
