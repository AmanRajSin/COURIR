using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    public GameObject[] building;
    public LayerMask BuildingLayer;

    private int randNum;
    private float del;
    private float prev;

	void Start () {
        Invoke("Spawn", 5.1f);
        prev = -4f;
	}

    void Spawn() { 
        randNum = ((int)Random.Range(0, 20));
        del = Random.Range(-1f, 1f);
        prev += del;
        if (prev >= 3.4f) prev = 3.4f;
        else if (prev <= -6.6f) prev = -6.6f;
        
        if (!Physics2D.OverlapArea(GetComponent<Collider2D>().bounds.min, GetComponent<Collider2D>().bounds.max, BuildingLayer)) {
            if (randNum % 2 == 0f) {
                Instantiate(building[randNum], new Vector3(transform.position.x, 0, transform.position.z) + new Vector3(9.8f, 1.8f + prev, -10f), Quaternion.identity);
                Invoke("Spawn", 0.5f);
            }
            else {
                Instantiate(building[randNum], new Vector3(transform.position.x, 0, transform.position.z) + new Vector3(15f, -4f + prev, 1f), Quaternion.identity);
                Invoke("Spawn", 0.7f);
            }
        }
        else 
            Invoke("Spawn", 0.3f);
    }
}
