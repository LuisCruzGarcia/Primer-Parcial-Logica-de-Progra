using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AngerScene : MonoBehaviour, PortalInterface
{
    public string question;
    public InputField answerField;
    public Text textField;
    public Text wrongField;
    public ControllerManagement controller;

    public void Start()
    {
        Initialize();
        Debug.Log(Convert.ToInt32(Math.Pow(5, 2)));
    }

    public void getAnswer(InputField answerField)
    {
        int value = Convert.ToInt32(Math.Pow(5, 2));
        if (Convert.ToInt32(answerField.text) == value)
        {
            controller.unloadPortal("anger");
            controller.PortalIntegrado();
            SceneManager.LoadScene("Hub");
        }
        else
        {
            wrongField.text = "Respuesta equivocada";
        }
    }

    public void goToHub()
    {
        SceneManager.LoadScene("Hub");
    }

    public void Initialize()
    {
        textField.text = question;
        wrongField.text = "";
        controller = GameObject.Find("Controller Management").GetComponent<ControllerManagement>();
    }
}
