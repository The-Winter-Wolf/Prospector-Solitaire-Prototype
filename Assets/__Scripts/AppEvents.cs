using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppEvents : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Выйти из приложения
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}