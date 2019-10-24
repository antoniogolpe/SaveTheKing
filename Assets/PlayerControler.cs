using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public GameObject player;
    public int speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) {
            player.transform.position = new Vector3(player.transform.position.x+speed*Time.deltaTime, player.transform.position.y, transform.position.z);
        }
        if (Input.GetKey("s")) {
            player.transform.position = new Vector3(player.transform.position.x - speed * Time.deltaTime, player.transform.position.y, transform.position.z);

        }

        if (Input.GetKey("a"))
        {
            player.transform.position = new Vector3(player.transform.position.x , player.transform.position.y , transform.position.z + speed * Time.deltaTime);

        }
        if (Input.GetKey("d"))
        {
            player.transform.position = new Vector3(player.transform.position.x , player.transform.position.y , transform.position.z - speed * Time.deltaTime);

        }
        if (Input.GetKey("left shift"))
        {
            speed = 4;
        }
        else {
            speed = 2;
        }

    }
}
