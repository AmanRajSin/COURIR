using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamScroll : MonoBehaviour {
	void Start () {
        Scroll();
	}   

    void Scroll ()
    {
        if (transform.position.y <= 12)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + (12f-transform.position.y)/600f + 0.01f, transform.position.z);
        }
        Invoke("Scroll", 0.001f);
    }
}
