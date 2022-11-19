using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int[] array;
    int[] array1 = new int[4];
    int[] array2 = new int[4] {21, 22, 23, 24};
    int[] array3 = new int[7] {31, 32, 33, 34, 35, 36, 37} ;
    string[] array4;
    GameObject[] arrayColoredImagesRed;

    private void Start()
    {
        for (int i = 0; i < array4.Length; i++)
        {
            array4[i] = "array4";
        }

        arrayColoredImagesRed = GameObject.FindGameObjectWithTag("RedImage");
    }


}
