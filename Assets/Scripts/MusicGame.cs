using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicGame : MonoBehaviour {

    public GameObject MPlayer;
    public AudioClip[] MClip;

    private int songNo;
    private AudioSource source;

    void Start () {
        songNo = PlayerPrefs.GetInt("SongNumber");
        source = MPlayer.GetComponent<AudioSource>();
        source.clip = MClip[songNo];
        source.Play();
    }
}
