using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    void Start()
    {
        ShakeStart();
    }

    public void ShakeStart()
    {
        StartCoroutine(shake());
    }

    public void ShortShakeStart()
    {
        StartCoroutine(shortshake());
    }

	IEnumerator shake()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.1f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.1f, transform.localPosition.z);
        
    }

    IEnumerator shortshake()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.3f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.6f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.4f, transform.localPosition.z);
        yield return new WaitForSeconds(0.1f);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.1f, transform.localPosition.z);
        
    }

}
