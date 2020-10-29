using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerManagement : MonoBehaviour
{
    public static ControllerManagement control;
    public int portalesActivos = 7;

    public string[,] portals = new string[9, 2] {
        { "limbo", "true" }, 
        { "lust", "true" },
        { "gluttony", "true" },
        { "greed", "true" },
        { "anger", "true" },
        { "heresy", "true" },
        { "violence", "true" },
        { "fraud", "true" },
        { "treachery", "true" },
    };

    private void Awake()
    {
        control = this;
        DontDestroyOnLoad(transform.gameObject);
    }

    public void PortalIntegrado()
    {
        portalesActivos--;
    }

    public int GetPortalesActivos()
    {
        return portalesActivos;
    }

    public void unloadPortal(string portal)
    {
        for(int i = 0; i <= 8; i++)
        {
            if(portals[i, 0] == portal)
            {
                portals[i, 1] = "false";
            }
        }
    }

    public bool getPortalStatus(string portal)
    {
        string status = "";

        for (int i = 0; i <= 8; i++)
        {
            if (portals[i, 0] == portal)
            {
                status = portals[i, 1];
            }
        }

        return Convert.ToBoolean(status);
    }
}
