using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;

    [Range(-10, 0)]
    public int offset_x;

    [Range(0, 10)]
    public int offset_y;

    [Range(0, 10)]
    public int offset_z;

    //[Range(-2f, 2f)]
    //public float rotateX;

    //[Range(-2f, 2f)]
    //public float rotateY;

    //[Range(-2f, 2f)]
    //public float rotateZ;

    //[Range(-2f, 2f)]
    //public float rotateW;

    //private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //offset = new Vector3(offset_x, offset_y, offset_z);
        transform.position = player.transform.position + new Vector3(offset_x, offset_y, offset_z);
        //rotateX = transform.rotation.x;
        //rotateY = transform.rotation.y;
        //rotateZ = transform.rotation.z;
        //rotateW = transform.rotation.w;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(offset_x, offset_y, offset_z);
    }
}
