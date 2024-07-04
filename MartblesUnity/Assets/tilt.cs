using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilt : MonoBehaviour
{
    public float smooth = 1.0f;
    public float rotateAngle = 10.0f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.interpolation = RigidbodyInterpolation.Interpolate;
    }

    void FixedUpdate()
    {
        float xRotation = Input.GetAxis("Horizontal") * rotateAngle;
        float zRotation = Input.GetAxis("Vertical") * rotateAngle;

        Quaternion bRotation = Quaternion.Euler(zRotation, 0.0f, -xRotation);
        rb.MoveRotation(Quaternion.Slerp(rb.rotation, bRotation, Time.fixedDeltaTime * smooth));
    }
}
