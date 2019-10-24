using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingControler : MonoBehaviour
{
    public GameObject player;
    public GameObject king;
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - king.transform.position;
        if (direction.magnitude > 3)
        {
            king.transform.position = king.transform.position + direction.normalized*Time.deltaTime;
        }
    }
}
