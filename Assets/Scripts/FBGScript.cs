using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBGScript : MonoBehaviour {
    void FixedUpdate()
    {
        transform.localPosition = new Vector3(transform.localPosition.x - 0.028f, transform.localPosition.y, transform.localPosition.z);
        if (transform.localPosition.x <= -25f)
        {
            transform.localPosition = new Vector3(32.76f, transform.localPosition.y, transform.localPosition.z);
        }
    }
}
