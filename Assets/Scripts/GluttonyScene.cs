using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GluttonyScene : MonoBehaviour, PortalInterface
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
        string value = "Cerbero";
        if (answerField.text == value)
        {
            controller.unloadPortal("gluttony");
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
