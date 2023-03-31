using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    private int hp = 100;
    private int power = 50;
    
    public void Attack()
    {
        Debug.Log(this.power + " 데미지를 입혔다.");
    }
    
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + " 데미지를 입었다. ");
    }

    public int GetHp()
    {
        return hp;
    }
}
public class Test_008 : MonoBehaviour
{

    public Text playerHp;
    public Text player2Hp;
    Player mplayer = new Player();
    Player mplayer2 = new Player();


    // Start is called before the first frame update
    void Start()
    {
        
      //  mPlayer.Attack();
       // mPlayer.Damage(30);
       // Debug.Log(mPlayer.GetHp());

    }

    // Update is called once per frame
    void Update()
    {
        playerHp.text = "Player 1 HP : " + mplayer.GetHp().ToString();
        player2Hp.text = "Player 2 Hp" + mplayer2.GetHp().ToString();

        if (Input .GetMouseButtonDown(0))
        {
            mplayer.Damage(1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            mplayer2.Damage(1);
        }
    }
}
