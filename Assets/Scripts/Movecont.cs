using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movecont : MonoBehaviour
{
    public GameObject[] points = new GameObject[6];

    public float speed;

    int index = 0;

    void Start()
    {


    }


    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, points[index].transform.position, step);

        if (transform.position == points[index].transform.position)
        {
            index++;
        }


        if (index == points.Length)
        {
            index = 0;
        }

    }
}
