using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class FingeruebungArray : MonoBehaviour
{
    int[] array;
    int[] array1 = new int[4];
    int[] array2 = new int[4] { 21, 22, 23, 24 };
    int[] array3 = new int[7] { 31, 32, 33, 34, 35, 36, 37 };
    string[] array4 = new string[10];
    [SerializeField] GameObject[] arrayColoredImagesRed;
    string longstring;
    int[] array5 = new int[48];
    int[] array6 = new int[498];
    int[] array7 = new int[498];
    string[] array8 = new string[100];
    int[] array9 = new int[1000];
    int[] array11 = new int[1000];
    int[] array12 = new int[1000];

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

        Debug.Log(array1[array1.Length - 1]);
        Debug.Log(array2[array2.Length - 1]);
        Debug.Log(array3[array3.Length - 1]);
        Debug.Log(array4[array4.Length - 1]);
        Debug.Log(arrayColoredImagesRed[arrayColoredImagesRed.Length - 1].name);

        for (int i = 0; i < array2.Length; i++)
        {
            Debug.Log("array2[" + i + "] = " + array2[i]);
        }
        for (int i = 0; i < array2.Length; i++)
        {
            longstring = longstring + array2[i] + " ";
        }
        Debug.Log(longstring);

        array1[3] = 3;
        Debug.Log(array1[3]);

        array2[2] = 203;
        Debug.Log(array2[2]);

        array3[5] = 333;
        Debug.Log(array3[5]);

        array4[2] = "heute";
        Debug.Log(array4[2]);

        arrayColoredImagesRed[2].GetComponent<Image>().color = Color.green;

        for (int i = 0; i < array5.Length; i++)
        {
            if (i % 2 == 0)
            {
                array5[i] = i + 22;
            }
        }

        for (int i = 0; i < array6.Length; i++)
        {
            if (i % 2 == 0)
            {
                array6[i] = i + 2;
            }
        }

        for (int i = 0; i < array7.Length; i++)
        {
            if (i % 2 == 1)
            {
                array7[i] = i;
            }
        }

        for (int i = 0; i < array8.Length; i++)
        {
            if (i % 2 == 0)
            {
                array8[i] = "a";
            }
            else if (i % 2 == 1)
            {
                array8[i] = "b";
            }
        }

        for(int i = 0; i < array9.Length; i++)
        {
            array9[i] = Random.Range(0, 1000);
        }
        System.Array.Sort(array9);
        for(int i = 0; i < array9.Length; i++)
        {
            Debug.Log(array9[i]);
        }

        int[] array10 = array5.Concat(array6).ToArray();

        for(int i = 0; i < array11.Length; i++)
        {
            array11[i] = Random.Range(0, 1000);
        }
        System.Array.Sort(array11);
        Debug.Log(array11[0] + " und " + array11[array11.Length - 1]);

        for(int i = 0; i < array12.Length; i++)
        {
            array12[i] = Random.Range(0, 1000);
        }
        int randomNum = Random.Range(0, 1000);
        Debug.Log(System.Array.IndexOf(array12, randomNum));
    }
}
