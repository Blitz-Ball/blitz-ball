using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tfollow : MonoBehaviour
{
    public Transform Player;
    public Transform Image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Image.position=Player.position;
        
    }
}
