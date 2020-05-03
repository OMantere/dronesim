using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constants;

public class DroneBehaviour : MonoBehaviour
{
    public Rigidbody rb;

    private float[] thrust;
    private Vector3[] engine;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thrust = new float[4] {0f, 0f, 0f, 10f};

        engine = new Vector3[4] {
           transform.Find("engine0").localPosition,
           transform.Find("engine1").localPosition,
           transform.Find("engine2").localPosition,
           transform.Find("engine3").localPosition
        };
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 4; i++) {
            rb.AddForceAtPosition(transform.up * thrust[i], new Vector3(0f, 0f, 0f));
        }
    }
}
