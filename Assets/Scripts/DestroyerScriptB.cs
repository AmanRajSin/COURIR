using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DestroyerScriptB : MonoBehaviour {

    public GameObject panel;
    public GameObject pauseBut;
    public GameObject GOLabel;
    public GameObject quitBut;
    public GameObject retBut;
    public GameObject scoreLabel;
    public Transform player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            GameOver(0);

        else if (other.tag == "Glass")
        {
            if(other.gameObject.transform.parent)
                Destroy(other.gameObject.transform.parent.gameObject);
            else
                Destroy(other.gameObject);
        }
    }

    void OnDisable()
    {
        Time.timeScale = 1;
    }

    public void GameOver(int type)
    {
        if (type == 0)
            panel.GetComponent<Image>().color = new Color(256f, 256f, 256f, 0.35f);
        else if (type == 1)
        {
            GetComponent<AudioSource>().Play();
            panel.GetComponent<Image>().color = new Color(256f, 256f, 256f, 256f);
        }
        Time.timeScale = 0;
        pauseBut.SetActive(false);
        GOLabel.SetActive(true);
        quitBut.SetActive(true);
        retBut.SetActive(true);
        scoreLabel.GetComponentInChildren<Text>().text = "You ran " + ((int)(player.position.x * 3)).ToString() + "m before dying.";
        scoreLabel.SetActive(true);
        if ((int)(player.position.x * 3) > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", (int)(player.position.x * 3));
        }
    }
}
