
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float value1 = 3.5f;
        float value2 = 2.0f;
        
        int resultadovalue = (int)(value1 + value2);
        Debug.Log(resultadovalue);


        float value3 = 4.90987f;
        string valor = string.Format("{0:F4}", value3);
        Debug.Log(valor);

        string MY_NAME = "Abraham Merchan Benitez";
        string NAME = MY_NAME.Substring(0, 7);
        string LASTNAME = MY_NAME.Substring(8, 7);
        string LASTNAME2 = MY_NAME.Substring(16, 7);

        Debug.Log("Nombre: " + NAME);
        Debug.Log("Apellido Paterno: " + LASTNAME);
        Debug.Log("Apellido Materno: " + LASTNAME2);

        string[] partes = MY_NAME.Split(' ');
        List<string> listanombres = new List<string>(partes);
        foreach (string parte in listanombres)
        {
            Debug.Log(parte);
        }

        string valor1 = "3000";
        string valor2 = "4500";
        int numero1;
        int numero2;
        bool convertido1 = int.TryParse(valor1, out numero1);
        bool convertido2 = int.TryParse(valor2, out numero2);

        
        if (convertido1 && convertido2)
        {
           
            int Resultado = numero1 + numero2;

            
            Debug.Log("Resultado de la suma: " + Resultado);
        }
        else
        {
            Debug.Log("Error al convertir los valores.");
        }


        string oracion = "Hola Profesor de EBAC y Hola Mundo"; 

       
        for (int i = 0; i < oracion.Length; i++)
        {
            
            if (i % 2 == 0)
            {
                
                Debug.Log(oracion[i]);

            }
        }
    
        string Frase = "Hola EBAC, prueba del modulo 8";  

        
        string resultado = Frase.Substring(5);

       
        Debug.Log("Resultado con Substring: " + resultado);
    }
    



    // Update is called once per frame
    void Update()
    {
        int numeroEntero = 10;
        numeroEntero *= 2;
    

    }
    void FixedUpdate()
    { 
        float numeroDecimal = 5.5f;
        numeroDecimal *= 2.5f;
        Debug.Log(numeroDecimal);

        int numeroEntero = 10;
        string Palabra;
        Palabra = (numeroEntero % 2 == 0) ? "Es Par" : "Es Impar";
        switch (Palabra)
        {
            case "Es Par":
                Color Par = Color.white;
                GetComponent<MeshRenderer>().material.color = Par;
                break;
            case "Es Impar":
                Color Impar = Color.black;
                GetComponent<MeshRenderer>().material.color = Impar;
                break;
        }

    }
}
