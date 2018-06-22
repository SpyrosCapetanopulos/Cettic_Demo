using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour {

    public GameObject panelFinish = null;
    public GameController gameController = null;
    public Text txtScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            txtScore.text = "Puntuación = " + gameController.score;
            panelFinish.SetActive(true);
        }

    }
}
