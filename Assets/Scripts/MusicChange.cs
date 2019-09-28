using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicChange : MonoBehaviour {

    public GameObject Button;
    public string[] MText;
    public GameObject MPlayer;
    public AudioClip[] MClip;

    private int songNo;
    private AudioSource source;

    void Start()
    {
        source = MPlayer.GetComponent<AudioSource>();
        songNo = PlayerPrefs.GetInt("SongNumber");
        Button.GetComponentInChildren<Text>().text = MText[(songNo) % 3];
        PlayerPrefs.SetInt("SongNumber", songNo % 3);
        source.clip = MClip[(songNo) % 3];
        source.Play();
    }

    public void MChange()
    {
        Button.GetComponentInChildren<Text>().text = MText[(++songNo) % 3];
        PlayerPrefs.SetInt("SongNumber", songNo % 3);
        source.clip = MClip[(songNo) % 3];
        source.Play();
    }
}
