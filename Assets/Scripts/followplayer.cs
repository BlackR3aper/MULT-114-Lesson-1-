using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 7, -10);
    //Camera angle for the player. 3rd person view


    // Comment

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
