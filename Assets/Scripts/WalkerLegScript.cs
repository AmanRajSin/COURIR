using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkerLegScript : MonoBehaviour {

    private GameObject walkerLeg;
    private float initialY;
    
    void Start()
    {
        walkerLeg = GameObject.FindGameObjectWithTag("WalkerLeg");
        initialY = transform.position.y - 1f;
    }

    void Update()
    {
        if (walkerLeg.transform.position.y <= initialY + 1.1f)
        {
            walkerLeg.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
            return;
        }
    }

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            walkerLeg.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -90f);
        }
        else if(other.tag == "WalkerLeg")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -90f);
            GetComponent<AudioSource>().Play();
            StartCoroutine(slowmo());
        }
    }

    IEnumerator slowmo()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        Time.timeScale = 0.3f;
        yield return new WaitForSeconds(0.9f);
        Time.timeScale = 1f;
    }
}
