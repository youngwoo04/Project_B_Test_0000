using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003_B : MonoBehaviour
{
    public int herbNum = 1;        //������\ herbNum �����Ŀ� 1�� �Է� (public �߰� , �ν�â���� �����ֱ� ���ؼ� ����)

    // Start is called before the first frame update
    void Start()
    {

        if(herbNum == 1)        //���ǽ� herbNum �� 1�� ��� �ȿ� ������ �����Ѵ�.
        {
            Debug.Log("ü���� 50 ȸ��");     //consloe.log â�� ������ ������ ��� �ش� ������ ǥ���Ѵ�.
        }
        else
        {
            Debug.Log("ü�� -50");            //console.log â�� ������ ������ ��� �ش� ������ ǥ���Ѵ�.
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
