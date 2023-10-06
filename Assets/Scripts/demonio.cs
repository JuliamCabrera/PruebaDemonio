using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demonio : MonoBehaviour
{

    public float speed = 5;
    public float range = 5;
    public LayerMask playerMask;
    public Transform player;
    private bool checkIsNear;

    void Start()
    {
    //player = player.transform.Find("Cylinder");
    }


    void Update()
    {
        followPlayer();
    }

    void followPlayer()
    {
        checkIsNear = Physics.CheckSphere(transform.position,range,playerMask);

        if(checkIsNear == false)
        {
        Vector3 playerPos = new Vector3(player.position.x,transform.position.y,player.position.z);
        transform.LookAt(playerPos);
        transform.position = Vector3.MoveTowards(transform.position,playerPos,speed * Time.deltaTime);
        }
    }
}
