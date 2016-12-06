using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    public Rigidbody lazer_prefab;
    public float lazer_speed = 500.0f;
    float shooting_cooldown = 2.0f;
    float last_shot = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
        {
            fireLazer();
        }
	}

    void fireLazer()
    {
        if(Time.time - last_shot < shooting_cooldown)
        {
            return;
        }

        Rigidbody lazerPrefab =
            Instantiate(lazer_prefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity) as Rigidbody;

        lazerPrefab.GetComponent<Rigidbody>().AddForce(new Vector3(0, lazer_speed));

        last_shot = Time.time;

    }

}
