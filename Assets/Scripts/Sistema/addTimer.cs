using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addTimer : MonoBehaviour {
    public Timer timer;
    public float timeValue = 5;

    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            timer.tiempoMax = timer.tiempoMax + timeValue;
            Destroy(gameObject);
        }
    }
}
