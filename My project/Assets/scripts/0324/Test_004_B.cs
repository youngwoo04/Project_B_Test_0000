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

        if (hp <= 50)                                    //50이하 일때
        {
           // Debug.Log("도망 !");
            TextUI.text = "도망 !";
        }
        else if (hp >= 200)                              //200이상일때
        {
           // Debug.Log("공격 !");
            TextUI.text = "공격 !";
        }
        else
        {
            //Debug.Log("방어!");
            TextUI.text = "방어 !";
        }


        hpTextUI.text = "HP : " + hp.ToString();
    }
}
