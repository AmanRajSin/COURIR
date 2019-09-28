using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowScript : MonoBehaviour {

    public Transform player;

	void Update ()
    { 
	    if(player.position.y <= 1 && player.position.y >=-4)
        {
            transform.position = player.position;
        }
        else
        {
            transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        }
	}
}
