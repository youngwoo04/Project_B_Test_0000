using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_006 : MonoBehaviour
{

    public int[] array = new int[5];
    public int[] points = { 83, 99, 52, 93, 15 };


   // Start is called before the first frame update
    void Start()
    {
        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for(int i = 0; i < 5; i ++)
        {
            Debug.Log(array[i]);
        }

        Debug.Log("==================================================");

        for(int i = 0; i < points.Length; i++)
        {
            if (points[i] > 90)
            {
                Debug.Log(points[i]);
            }
        }

        int sum = 0;

        for (int i = 0; i < points.Length; i++)
        {
            sum += points[i];
        }

        int average = sum / points.Length;

        Debug.Log(average);






    }

   
}
