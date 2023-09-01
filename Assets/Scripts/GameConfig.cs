using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameConfig : MonoBehaviour
{
    public Text Team11;
    public Text Team12;
    public Text Team21;
    public Text Team22;
    public GameObject Striker1;
    public GameObject Striker2;
    public GameObject Striker3;
    //public player4 Striker4;
    public SpriteRenderer Striker1s;
    public SpriteRenderer Striker2s;
    public SpriteRenderer Striker3s;
    public SpriteRenderer Striker4s;
    
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;

    // Start is called before the first frame update
    void Start()
    {
        Striker1s.material.color=Singleton.Instance.colp1;
        Striker2s.material.color=Singleton.Instance.colp2;
        Striker3s.material.color=Singleton.Instance.colp1;
        Striker4s.material.color=Singleton.Instance.colp2;
        Team11.color=Singleton.Instance.colp1;
        Team12.color=Singleton.Instance.colp1;
        Team22.color=Singleton.Instance.colp2;
        Team21.color=Singleton.Instance.colp2;

        
        
        if(Singleton.Instance.IsPlayer1==true)
        {
            Striker2.GetComponent<Player2>().enabled=false;
            Striker3.GetComponent<player3>().enabled=false;
            P2.SetActive(false);
            P3.SetActive(false);
        }
        else
        {
            if(Singleton.Instance.IsPlayerFriend==true)
            {
                Striker2.GetComponent<Player2>().enabled=false;
                P2.SetActive(false);
            }
            else
            {
                Striker3.GetComponent<player3>().enabled=false;
                P3.SetActive(false);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
