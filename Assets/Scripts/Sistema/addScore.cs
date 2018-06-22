using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class addScore : MonoBehaviour {

    public int scoreValue;
    public GameController gameController = null;

    void Start ()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            gameController.AddScore(scoreValue);
            Destroy(gameObject);
        }

    }
}