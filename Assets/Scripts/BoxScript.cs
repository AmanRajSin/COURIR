using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour {

    private GameObject player;
    private PlatformerCharacter2D scr;
    private SpriteRenderer render;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        render = GetComponent<SpriteRenderer>();
        scr = player.GetComponent<PlatformerCharacter2D>();
    }
	void  OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            render.color = new Color(0.92f, 0.92f, 0.92f, 0.2f);
            scr.maxSpeed /= 1.2f;
        }
    }
}
