using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    SurfaceEffector2D surfaceEffector2D;

    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 100f;
    [SerializeField] float baseSpeed = 50f;
    bool canMove = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RepondToBoost();
        }
    }

    public void DisableControlls()
    {
        canMove = false;
    }

    private void RotatePlayer()
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

    private void RepondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
