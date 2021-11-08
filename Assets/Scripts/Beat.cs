using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    [SerializeField] float enlarge_by = 1f;
    [SerializeField] float speed = 1f;
    float init_scale;
    // Start is called before the first frame update
    void Start()
    {
        init_scale = transform.localScale.x; // in our case, x = y = z
    }

    // Update is called once per frame
    void Update()
    {
        float x = (float)Mathf.Abs(Mathf.Sin(speed*Time.time))*enlarge_by + init_scale;
        transform.localScale = new Vector3(x, x, x);
    }
}
