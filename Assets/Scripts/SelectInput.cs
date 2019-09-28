using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectInput : MonoBehaviour {

    public GameObject Canvas;
    public EventSystem eventSys;
    public GameObject selectedObj;

    private bool butSelected;
    private int HScore;

    void Start()
    {
        HScore = PlayerPrefs.GetInt("HighScore");
        Canvas.GetComponentInChildren<Text>().text = "High Score: " + HScore.ToString() + "m";
    }

	void Update()
    {
        if(Input.GetAxisRaw("Vertical")!=0 && butSelected  == false)
        {
            eventSys.SetSelectedGameObject(selectedObj);
            butSelected = true;
        }
    }

    private void OnDisable()
    {
        butSelected = false;
    }
}
