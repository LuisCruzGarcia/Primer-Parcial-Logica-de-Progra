using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FraudScene : MonoBehaviour, PortalInterface
{
    public string question;
    public InputField answerField;
    public Text textField;
    public Text wrongField;
    public ControllerManagement controller;

    public void Start()
    {
        Initialize();
    }

    public void getAnswer(InputField answerField)
    {
        int value = 5 * 5;
        if (Convert.ToInt32(answerField.text) == value)
        {
            controller.PortalIntegrado();
            controller.unloadPortal("fraud");
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
