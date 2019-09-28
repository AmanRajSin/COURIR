using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScript : MonoBehaviour {
	void FixedUpdate () {
        transform.localPosition = new Vector3(transform.localPosition.x - 0.08f, transform.localPosition.y, transform.localPosition.z);
        if(transform.localPosition.x <= -25f) {
            transform.localPosition = new Vector3(52.07f, transform.localPosition.y, transform.localPosition.z);
        }
	}
}
