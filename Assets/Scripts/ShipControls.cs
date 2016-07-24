using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShipControls : MonoBehaviour {

    bool fly;
    new Rigidbody rigidbody;
    float otherY;

	public Master.Character myChar;

    public Image UIImage;
	public Text Place;
	public Text Lap;
    public Sprite sprShoot, sprBoost, sprDerp;
    public float ForceScale = 1f;
    public float MaxSpeed = 30;
    public float BoostBonusSpeed = 30;
    public float BoostBonusAccel = 10;
    public float CollisionBonusSpeed = 10;
    public float Acceleration = 40;
    public float TurnRate = 3;
    public bool IsDatBoi = false;
    public EPowerUp powerup = EPowerUp.None;
    public float CollisionPupTime = -1f;
    public float BoostTime = -1f;
    new public Camera camera; // IF NOT NULL, IS GIRL/DICKBUTT
    public GameObject bulletPrefab;
    public GameObject explosionPrefab;
    public float fuckedTimer = -1f;
    public GameObject PSCollide;
    public GameObject PSBoost;

    private float dontExplode = -1f;

	private bool isPlayerNameAssigned;
	private int playerNum;

	private SpawnerManager m_Spawn;

	// Use this for initialization
	void Start ()
    {
		playerNum = -1;
		isPlayerNameAssigned = false;
        fly = false;
        rigidbody = GetComponent<Rigidbody>();
        otherY = 0;

		m_Spawn = GameObject.FindGameObjectWithTag ("SpawnManager").GetComponent<SpawnerManager> ();
    }

    // Update is called once per frame
    void Update ()
    {
        if (!isPlayerNameAssigned)
        {
            playerNum = int.Parse(this.gameObject.name[this.gameObject.name.Length - 1].ToString());
            isPlayerNameAssigned = true;
        }

        if (dontExplode >= 0)
        {
            dontExplode -= Time.deltaTime;
        }

        if (CollisionPupTime >= 0)
        {
            PSCollide.SetActive(true);
            CollisionPupTime -= Time.deltaTime;
            if (CollisionPupTime < 0)
            {
                PSCollide.SetActive(false);
                MaxSpeed -= CollisionBonusSpeed;
            }
        }

        if (BoostTime >= 0)
        {
            PSBoost.SetActive(true);
            BoostTime -= Time.deltaTime;
            if (BoostTime < 0)
            {
                PSBoost.SetActive(false);
                MaxSpeed -= BoostBonusSpeed;
                Acceleration -= BoostBonusAccel;
            }
        }

        if (fuckedTimer >= 0)
        {
            fuckedTimer -= Time.deltaTime;
            if (fuckedTimer < 0)
            {
                rigidbody.rotation = Quaternion.identity;
                rigidbody.freezeRotation = true;
                rigidbody.velocity = Vector3.zero;
            }
        }

        if (fly && !IsDatBoi)
        {
            rigidbody.AddForce(-Physics.gravity);
            rigidbody.AddForce(Vector3.up * 10 * (1 - (transform.position.y - otherY)) * ForceScale);
        }

        if (Input.GetButton("p" + playerNum + "_Jump"))
        {
            rigidbody.angularVelocity = Vector3.zero;
            if (Vector3.Dot(rigidbody.velocity, -transform.forward) < MaxSpeed)
            {
                if (!IsDatBoi)
                    rigidbody.AddForce((camera ? camera.transform.forward : -transform.forward) * Acceleration * ForceScale);
                else
                {
                    float temp = rigidbody.velocity.y;
                    rigidbody.velocity -= temp * Vector3.up;
                    rigidbody.velocity = -transform.forward * MaxSpeed;
                    rigidbody.velocity += temp * Vector3.up;
                }
            }
        }
        else if (Input.GetAxis("p" + playerNum + "_Bury") < -0.2f)
        {
            if (Vector3.Dot(-rigidbody.velocity, -transform.forward) > -MaxSpeed)
            {
                if (!IsDatBoi)
                    rigidbody.AddForce((camera ? -camera.transform.forward : transform.forward) * Acceleration * ForceScale);
                else
                {
                    float temp = rigidbody.velocity.y;
                    rigidbody.velocity -= temp * Vector3.up;
                    rigidbody.velocity = transform.forward * MaxSpeed;
                    rigidbody.velocity += temp * Vector3.up;
                }
            }
        }
        else
        {

            if (!IsDatBoi)
            {
                float temp = rigidbody.velocity.y;
                rigidbody.velocity -= temp * Vector3.up;
                rigidbody.velocity *= 0.99f;
                rigidbody.velocity += temp * Vector3.up;
            }
            else
            {
                rigidbody.velocity -= rigidbody.velocity.x * Vector3.right;
                rigidbody.velocity -= rigidbody.velocity.z * Vector3.forward;
            }
        }

		if (Input.GetButtonDown ("p" + playerNum + "_Reset")) {
			Destroy (UIImage.transform.parent.parent.gameObject);
			Debug.Log ("Destroying Player: " + playerNum);
			StartCoroutine (m_Spawn.RespawnPlayer (playerNum - 1, gameObject));
		}

		if (Input.GetAxis("p" + playerNum + "_Strafe") < -0.2f)
        {
            if (camera)
                rigidbody.AddForce(-camera.transform.right * Acceleration * ForceScale);
            else
                transform.Rotate(Vector3.up * -TurnRate);
        }

		if (Input.GetAxis("p" + playerNum + "_Strafe") > 0.2f)
        {
            if (camera)
                rigidbody.AddForce(camera.transform.right * Acceleration * ForceScale);
            else
                transform.Rotate(Vector3.up * TurnRate);
        }

        float y = rigidbody.velocity.y;
        rigidbody.velocity -=  y * Vector3.up;
        if (camera)
        {
            if (rigidbody.velocity.sqrMagnitude > MaxSpeed * MaxSpeed)
                rigidbody.velocity = rigidbody.velocity.normalized * MaxSpeed;
        }
        else if (Vector3.Dot(rigidbody.velocity, -transform.forward) > MaxSpeed)
            rigidbody.velocity = rigidbody.velocity.normalized * MaxSpeed;
        rigidbody.velocity += y * Vector3.up;
        
        if (Input.GetButton("p" + playerNum + "_Drop"))
        {
            UsePowerup();
        }

        GameObject[] bullets = GameObject.FindGameObjectsWithTag("Kaboom");
        foreach (GameObject g in bullets)
        {
            if ((g.transform.position - this.transform.position).magnitude <= 7)
            {
                GetRekt(g);
            }
        }
    }

    public void GetRekt(GameObject other)
    {
        if (dontExplode < 0)
        {
            ShakeScreen(20);
            dontExplode = 0.5f;
            GameObject.Instantiate(explosionPrefab, other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);

            rigidbody.freezeRotation = false;
            fuckedTimer = 2f;
            rigidbody.velocity = Vector3.zero;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (CollisionPupTime > 0)
            {
                other.gameObject.GetComponent<Rigidbody>().freezeRotation = false;
                ShipControls found = other.gameObject.GetComponent<ShipControls>();
                while (found == null)
                    found = found.transform.parent.GetComponent<ShipControls>();
                found.fuckedTimer = 2f;
                other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }

    public void GetPowerup()
    {
        switch (Random.Range(1, 4))
        {
            case 1:
                powerup = EPowerUp.Boost;
                UIImage.sprite = sprBoost;
                break;
            case 2:
                powerup = EPowerUp.Collision;
                UIImage.sprite = sprDerp;
                break;
            case 3:
                powerup = EPowerUp.Projectile;
                UIImage.sprite = sprShoot;
                break;
            default:
                powerup = EPowerUp.None;
                break;
        }
    }

    void UsePowerup()
    {
        switch (powerup)
        {
            case EPowerUp.Boost:
                BoostTime = 2f;
                MaxSpeed += BoostBonusSpeed;
                Acceleration += BoostBonusAccel;
                break;
            case EPowerUp.Collision:
                CollisionPupTime = 7f;
                MaxSpeed += CollisionBonusSpeed;
                break;
            case EPowerUp.Projectile:
                GameObject b = (GameObject)GameObject.Instantiate(bulletPrefab, transform.position + (camera ? (camera.transform.forward - Vector3.up * camera.transform.forward.y) * 2 : -transform.forward * 15),
                                Quaternion.Euler(90 * Vector3.right + (camera ? camera.transform.rotation.eulerAngles.y * Vector3.up + camera.transform.rotation.eulerAngles.z * Vector3.forward
                                                                              : transform.rotation.eulerAngles.y * Vector3.up + transform.rotation.eulerAngles.z * Vector3.forward)));
                b.GetComponent<Rigidbody>().velocity = (camera ? camera.transform.forward - Vector3.up * camera.transform.forward.y : -transform.forward) * 50;
                break;
            case EPowerUp.None:
                // You don't have a powerup ya dingus
                break;
        }
        powerup = EPowerUp.None;
        UIImage.sprite = null;
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

    private void ShakeScreen(int amount)
    {
        ScreenShake c = UIImage.transform.parent.parent.GetComponent<ScreenShake>();
        if (c != null)
            c.setShake(amount);
        else
            Debug.LogError("Screenshake is missing, but let's not crash just in case");
    }

    public enum EPowerUp
    {
        None,
        Boost,
        Collision,
        Projectile
    }
}
