using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Networking;

public class RegisterPlayer : MonoBehaviour
{
    public TMP_InputField nameField;
    public Button submitButton;

    public void CallRegister(){
        StartCoroutine(Register());
    }

    IEnumerator Register(){
        WWWForm form = new WWWForm();
        form.AddField("username", nameField.text);
        UnityWebRequest www = UnityWebRequest.Post("http://localhost:8888/sqlconnect/register.php", form);
        yield return www.SendWebRequest();
        if(www.result == UnityWebRequest.Result.Success){
            Debug.Log("User created successfully.");
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        }
        else{
            Debug.Log("User creation failed. Error #" + www.error);
        }
    }

    public void verifyInputs(){
        submitButton.interactable = (nameField.text.Length <= 10);
    }
}
