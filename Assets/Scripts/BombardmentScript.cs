using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombardmentScript : MonoBehaviour {

    public GameObject bomb;

	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            bomb.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -70f);
        }
    }
}
