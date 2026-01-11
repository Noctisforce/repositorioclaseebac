using UnityEngine;

public class CiclosyArreglos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arreglos = new int[10];

        for (int i = 0; i < arreglos.Length; i++)
        {
            arreglos[i] = Random.Range(0, 101);
        }

        int[] Arreglos1 = new int[10];
        for (int i = 0; i < Arreglos1.Length; i++)
        {
            Arreglos1[i] = Random.Range(0, 101);
        }

        int[] suma = new int[10];
        for (int i = 0; i < suma.Length; i++)
        {
            suma[i] = arreglos[i] + Arreglos1[i];
            Debug.Log("La suma del indice " + i + " es: " + suma[i]);
        }

        string[] Oracion = { "Me", "gusta", "programar", "en", "Unity,", "hola", "EBAC" };
        string Frase = "";

        foreach (string palabra in Oracion)
        {
            Frase += palabra + " ";
        }

        Debug.Log("Frase completa: " + Frase.Trim());

        int[,] matrizA = new int[2, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
        };

        int[] VectorB = { 9, 10, 4 };

        int[] resultado = new int[2];

        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            resultado[i] = 0;
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                resultado[i] += matrizA[i, j] * VectorB[j];
            }
            Debug.Log("El resultado del indice " + i + " es: " + resultado[i]);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
