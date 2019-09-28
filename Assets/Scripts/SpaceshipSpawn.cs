using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipSpawn : MonoBehaviour {

    public GameObject spaceship;
    public GameObject cam;

    void Start ()
    {
        Invoke("Spawn", 5f);
	}

    void Spawn ()
    {
        GetComponent<AudioSource>().Play();
        cam.GetComponent<CameraShake>().ShakeStart();
        Instantiate(spaceship, transform.position, Quaternion.identity);
        Invoke("Spawn", 22f);
    }
}
