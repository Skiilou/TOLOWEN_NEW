using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEngine.Tilemaps.Tilemap;

public class Deplacement2 : MonoBehaviour
{
    // Start is called before the first frame update



    private float floatSpeed=5f;
    public float speed;
    public Transform orientation;
    public Transform camer;
    public CharacterController controller;
    public float rotationSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        speed = floatSpeed;
        //Vector3 viewDirection=transform.position-new Vector3(camer.position.x,transform.position.y,camer.position.z);
        //orientation.forward = viewDirection.normalized;
        //Vector3 move = orientation.forward * z + orientation.right * x;

        Vector3 move = new Vector3(x*speed,0,z*speed);
        if (move!=Vector3.zero)
        {
            controller.Move(move * Time.deltaTime);
            transform.forward=Vector3.Lerp(transform.forward,move.normalized,Time.deltaTime*rotationSpeed);
        }

    }
}
