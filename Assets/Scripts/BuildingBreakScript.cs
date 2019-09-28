using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBreakScript : MonoBehaviour {

    private GameObject cam;
    private CameraShake scr;

    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        scr = cam.GetComponent<CameraShake>();
    }

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            scr.ShakeStart();
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -2f);
            GetComponent<AudioSource>().Play();
        }
    }
}
