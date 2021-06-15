using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Player player;
    public Vector3 vector;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        speed = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        //if (player.transform.position.x > this.transform.position.x)
        //{
        //    vector = Vector3.right;
        //    transform.position+= vector * speed * Time.deltaTime;
        //}
        //else if(player.transform.position.x < this.transform.position.x)
        //{
        //    vector = Vector3.left;
        //    transform.position += vector * speed * Time.deltaTime;
        //}
        // if(player.transform.position.y< this.transform.position.y)
        //{
        //    transform.position = new Vector3(this.transform.position.x, transform.position.y *-speed*Time.deltaTime,transform.position.z);
        //}
        //if (player.transform.position.y < this.transform.position.y)
        //{
        //    transform.position = new Vector3(this.transform.position.x, transform.position.y * speed * Time.deltaTime, transform.position.z);
        //}

    }
}
