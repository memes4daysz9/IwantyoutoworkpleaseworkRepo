using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVansRearEnd : MonoBehaviour
{
float VerticleInput;
float HorizontalInput;
float Speed;
float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VerticleInput = Input.GetAxis("Vertical");
       Transform.translate(Vector3.forward * VerticleInput * Speed);

       HorizontalInput=Input.GetAxis("Horizontal");
       Transform.rotate(Vector3.right * RotationSpeed * HorizontalInput);

    }
}
