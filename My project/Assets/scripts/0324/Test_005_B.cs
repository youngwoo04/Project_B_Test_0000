using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_005_B : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < 5; i++)                  //0부터 4까지 i 출력
        //{
        //    debug.log(i);
        //}

        //for (int i = 0; i < 10; i += 2)                //0부터 10까지 i 출력
        //{
        //    debug.log(i);
        //}

        //for (int i = 3; i > 0; i--)                  //3부터 0까지 i 출력
        //{
        //    debug.log(i);
        //}

        for(int i = 0; i < 10; i++)
        {
            if(i%2 ==0)  //%는 나머지 값 
            {
                Debug.Log(i);
            }
        }

        Debug.Log("=================================================");

        int sum = 0;
        for(int i = 0; i < 10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);

        Debug.Log("=========================================");

        for(int i= 0; i < 10; i++)
        {
            for(int j =0; j < 10; j++)
            {
                Debug.Log(i.ToString() + " x " + j.ToString() + " = " + (i * j).ToString());         
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
