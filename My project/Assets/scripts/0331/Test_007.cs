using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
   void SayHello()
    {
        Debug.Log("====================");
        Debug.Log("Hello");
        Debug.Log("====================");

    }
    void CallName(string name)
    {
        Debug.Log("Hello" + name);
    }

    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }

    void Start()
    {
        CallName("Tom");
        CallName("Harry");
        CallName("Lora");

        int answer;
        answer = Add(2, 3);
        Debug.Log(answer);
        Debug.Log(Add(7, 9));

    }
    

    
}
