using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void cerrarSesion(){
        SceneManager.LoadScene(0);
    }
    public void restarLevel(){
        SceneManager.LoadScene(1);
    }
}
