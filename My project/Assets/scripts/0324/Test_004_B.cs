using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_004_B : MonoBehaviour
{
    public int hp = 180;
    public Text TextUI;
    public Text hpTextUI;
   

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            hp += 10;
        }

        if(Input.GetMouseButtonDown(1))
        {
            hp -= 10;
        }

        if (hp <= 50)                                    //50���� �϶�
        {
           // Debug.Log("���� !");
            TextUI.text = "���� !";
        }
        else if (hp >= 200)                              //200�̻��϶�
        {
           // Debug.Log("���� !");
            TextUI.text = "���� !";
        }
        else
        {
            //Debug.Log("���!");
            TextUI.text = "��� !";
        }


        hpTextUI.text = "HP : " + hp.ToString();
    }
}
