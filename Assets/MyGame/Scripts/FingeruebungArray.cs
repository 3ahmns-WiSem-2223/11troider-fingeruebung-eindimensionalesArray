using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingeruebungArray : MonoBehaviour
{
    int[] array;
    int[] array1 = new int[4];
    int[] array2 = new int[4] { 21, 22, 23, 24 };
    int[] array3 = new int[7] { 31, 32, 33, 34, 35, 36, 37 };
    string[] array4 = new string[10];
    [SerializeField] GameObject[] arrayColoredImagesRed;


    private void Start()
    {
        for (int i = 0; i < array4.Length; i++)
        {
            array4[i] = "array4";
        }

        arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");

        Debug.Log(array1[0]);
        Debug.Log(array2[0]);
        Debug.Log(array3[0]);
        Debug.Log(array4[0]);
        Debug.Log(arrayColoredImagesRed[0].name);

        Debug.Log(array1[array1.Length-1]);
        Debug.Log(array2[array2.Length-1]);
        Debug.Log(array3[array3.Length-1]);
        Debug.Log(array4[array4.Length-1]);
        Debug.Log(arrayColoredImagesRed[arrayColoredImagesRed.Length - 1].name);


    }

}
