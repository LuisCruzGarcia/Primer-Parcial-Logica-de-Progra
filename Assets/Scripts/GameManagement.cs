using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    public Text portalesActivosTexto;
    public ControllerManagement controller;

    private void Start()
    {
        controller = GameObject.Find("Controller Management").GetComponent<ControllerManagement>();
        portalesActivosTexto.text = controller.GetPortalesActivos().ToString();
    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null)
            {
                switch (hit.collider.name)
                {
                    case "Limbo":
                        if (Input.GetKey("mouse 0") && controller.getPortalStatus("limbo"))
                        {
                            SceneManager.LoadScene("Limbo");
                        }
                        break;
                    case "Lust":
                        if (Input.GetKey("mouse 0") && controller.getPortalStatus("lust"))
                        {
                            SceneManager.LoadScene("Lust");
                        }
                        break;
                    case "Gluttony":
                        if (Input.GetKey("mouse 0") && controller.getPortalStatus("gluttony"))
                        {
                            SceneManager.LoadScene("Gluttony");
                        }
                        break;
                    case "Greed":
                        if (Input.GetKey("mouse 0") && controller.getPortalStatus("greed"))
                        {
                            SceneManager.LoadScene("Greed");
                        }
                        break;
                    case "Anger":
                        if (Input.GetKey("mouse 0") && controller.getPortalStatus("anger"))
                        {
                            SceneManager.LoadScene("Anger");
                        }
                        break;
                    case "Heresy":
                        if (Input.GetKey("mouse 0") && controller.getPortalStatus("heresy"))
                        {
                            SceneManager.LoadScene("Heresy");
                        }
                        break;
                    case "Violence":
                        if (Input.GetKey("mouse 0") && controller.getPortalStatus("violence"))
                        {
                            SceneManager.LoadScene("Violence");
                        }
                        break;
                    case "Fraud":
                        if (Input.GetKey("mouse 0") && controller.getPortalStatus("fraud"))
                        {
                            SceneManager.LoadScene("Fraud");
                        }
                        break;
                    case "Treachery":
                        if (Input.GetKey("mouse 0") && controller.getPortalStatus("treachery"))
                        {
                            SceneManager.LoadScene("Treachery");
                        }
                        break;
                    default:
                        Debug.Log("Default");
                        break;
                }
            }

        if (controller.GetPortalesActivos() <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
