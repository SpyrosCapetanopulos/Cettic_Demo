using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class register : MonoBehaviour {
    /* Obtenemos los datos para ser enviados a la base de datos  */
    public Text email;
    public InputField password;
    public Text username;
    public Text txtPopUp;
    /* Se registran los Paneles de Login, Register y Popup  */
    public GameObject subPanel = null;
    public GameObject PrincialPanel = null;
    public GameObject popUpPanel = null;

    string registerURL = "http://localhost/Cettic_demo/insert.php";

    private void Start()
    {
    }

    public void RegisterAttempt()
    {
        StartCoroutine(RegisterToBD());
    }


    IEnumerator RegisterToBD()
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username.text);
        form.AddField("passwordPost", password.text);
        form.AddField("emailPost", email.text);

        WWW www = new WWW(registerURL, form);
        yield return www;

        switch (www.text)
        {
            case "Se ha creado el nuevo usuario": //success
                txtPopUp.text = "Se ha creado el nuevo usuario";
                PrincialPanel.SetActive(false);
                subPanel.SetActive(false);
                popUpPanel.SetActive(true);
                break;
            case "Correo ya existe": //password incorrect
                txtPopUp.text = "Correo ya existe";
                PrincialPanel.SetActive(false);
                subPanel.SetActive(false);
                popUpPanel.SetActive(true);
                break;
            case "Usuario ya existe": //user not found
                txtPopUp.text = "Usuario ya existe";
                PrincialPanel.SetActive(false);
                subPanel.SetActive(false);
                popUpPanel.SetActive(true);
                break;
        }
    }
}