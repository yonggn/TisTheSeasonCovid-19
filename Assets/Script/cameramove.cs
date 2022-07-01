using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public Transform player;
    public AudioSource bgm;
    // Start is called before the first frame update
    void Start()
    {
        bgm.Play();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, -10);
       
    }
}
