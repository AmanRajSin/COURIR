using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BombXplosion : MonoBehaviour {

    List<GameObject> stones = new List<GameObject>();

    private GameObject destroyer;
    private DestroyerScriptB scr;
    private AudioSource source;
    private GameObject cam;
    private CameraShake scr1;

    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        scr1 = cam.GetComponent<CameraShake>();
        destroyer = GameObject.Find("DestroyerB");
        stones.Add(gameObject.transform.GetChild(0).gameObject);
        stones.Add(gameObject.transform.GetChild(1).gameObject);
        stones.Add(gameObject.transform.GetChild(2).gameObject);
        stones.Add(gameObject.transform.GetChild(3).gameObject);
        stones.Add(gameObject.transform.GetChild(4).gameObject);
        scr = destroyer.GetComponentInChildren<DestroyerScriptB>();
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Building")
        {
            stones[0].SetActive(true);
            stones[1].SetActive(true);
            stones[2].SetActive(true);
            stones[3].SetActive(true);
            stones[4].SetActive(true);
            source.Play();
            scr1.ShortShakeStart();
        }
        else if(other.tag == "Player")
        {
            scr.GameOver(1);          
        }
    }
}
