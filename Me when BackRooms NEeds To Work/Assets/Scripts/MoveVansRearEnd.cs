using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVansRearEnd : MonoBehaviour
{
float VerticleSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VerticleSpeed = Input.GetAxis("Vertical")
       TransForm.translate(Vector3.forward * Time.deltaTime * VerticleSpeed); 
    }
}
