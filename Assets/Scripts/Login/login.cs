using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class login : MonoBehaviour {

    public Text username;
    public InputField password;

    public GameObject popUpPanel = null;
    public Text txtPopUp;
    public GameObject principalPanel = null;

    Image passwordImage;

    string loginURL = "http://localhost/Cettic_demo/login.php";
    string getUserURL = "http://localhost/Cettic_demo/select.php";

    private void Start()
    {
    }

    public void LoginAttempt()
    {
        StartCoroutine(LoginToBD());
    }

    IEnumerator getUser(){
        string usernames = string.Empty;
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username.text);
        WWW www = new WWW(getUserURL, form);
        yield return www;
        usernames = www.text;


        //return usernames;
    }



    void LoadNextLevel()
    {
        var nombre = getUser();
        PlayerPrefs.SetString("PlayerName", nombre.ToString());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator LoginToBD()
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username.text);
        form.AddField("passwordPost", password.text);

        WWW www = new WWW(loginURL, form);
        yield return www;
        
        switch (www.text)
        {
            case "true": //success
                LoadNextLevel();
                break;
            case "false": //password incorrect
                //Abrir PopUP para decir que la contraseña es incorrecta
                txtPopUp.text = "Contraseña Incorrecta.";
                popUpPanel.SetActive(true);
                principalPanel.SetActive(false);
                break;
            case "false_user": //user not found
                txtPopUp.text = "Email Incorrecto.";
                popUpPanel.SetActive(true);
                principalPanel.SetActive(false);
                break;
        }
    }
}
