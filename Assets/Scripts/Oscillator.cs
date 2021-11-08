using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{

    [SerializeField] private float max_distance = 1;
    [SerializeField] private float speed = 1;
    private float origin_x;
    public enum directions
    {
        Right,
        Left
    };
    public directions starting_direction;


    // Start is called before the first frame update
    void Start()
    {
        origin_x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float x;
        if (starting_direction == directions.Left)
        {
            x = (origin_x - Mathf.Sin(speed*Time.time) * max_distance);
        }
        else
        {
            x = (origin_x + Mathf.Sin(speed*Time.time) * max_distance);
        }
        
        float y = transform.position.y;
        float z = transform.position.z;
        Vector3 v = new Vector3(x, y, z);
        transform.position = v;
    }
}
