using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] float torqueAmount = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torqueAmount);
            Debug.Log("Left");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torqueAmount);
            Debug.Log("Right");
        }
    }
}
