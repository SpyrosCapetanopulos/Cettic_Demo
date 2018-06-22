using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour {

    public Text timerText;
    public float tiempoMax = 30;
    private bool tiempoAgotado = false;
    public GameObject panelGameOver = null;
    UnityChanControlScriptWithRgidBody_editado editado;

    void Start()
    {
        timerText = GetComponent<Text>();
        if (tiempoMax == 0)
        {
            tiempoMax = 30;
        }
    }

    void Update()
    {
        if (!tiempoAgotado)
        {
            if (tiempoMax < 0)
            {
                tiempoAgotado = true;
            }
            else
            {
                timerText.text = string.Format("{0}:{1}", (int)(tiempoMax / 60), (tiempoMax % 60).ToString("00"));
                tiempoMax -= Time.deltaTime;
            }
        }

        if (tiempoAgotado)
        {
            panelGameOver.SetActive(true);
            editado.forwardSpeed = 0f;
        }
    }
}
