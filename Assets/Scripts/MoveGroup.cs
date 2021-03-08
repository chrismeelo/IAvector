using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGroup : MonoBehaviour
{
    public float speed;
    public GameObject player2;

    void Start()
    {

    }


    void Update()
    {

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(10, 0, 0), step);
        player2.transform.position = Vector3.MoveTowards(player2.transform.position, new Vector3(10, 0, 0), step);
    }
}
