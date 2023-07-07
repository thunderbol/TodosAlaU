using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EjercicioWhile : MonoBehaviour
{

    //Preguntar por la edad del usuario y entrar al bucle si tiene entre 25 y 35 años, 
    //    al entrar solo debe notificarle que escriba “FIN” para terminar.

    public int edad = 0;
    public string texto;

    void Start()
    {
        if (edad >= 25 && edad <= 35)
        {
            while (true)
            {

                if (texto == "FIN")
                {
                    break; //Sale del bucle si el usuario escribe FIN
                }
            }
        }
        else
        {
            Debug.Log("No cumples la edad para entrar en el bucle");
        }
    }

//int  ObtenerEdadUsuario()
//    {
//        Debug.Log("¿Cúal es tu edad?");
//        string input = Console.ReadLine();
//        int edad;
//        while (!int.TryParse(input, out edad))
//        {
//            Debug.Log("Ingrea una edad válidad");
//                input = Console.ReadLine();
//        }

//        return edad;
//    }


//   int ObtenerInpuntUsuario()
//    {
//        Debug.Log("Escribe FIN para terminar");
//        string input = Console.ReadLine();
//        return input;
//    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
