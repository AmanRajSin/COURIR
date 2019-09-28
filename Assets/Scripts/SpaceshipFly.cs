using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipFly : MonoBehaviour {

	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-90f, 0f);
	}
}
