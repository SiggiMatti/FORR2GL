using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private breytur sem sjást aðeins í kóðanum hér. Þær halda utan um hraða.
    private float speed = 5.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Stert er kallað áður en fyrsta uppfærsla skjásins
    void Start()
    {
        
    }

    // Update er kallað á hverjum frame
    void Update()
    {
        // Hér fæ ég innslátt frá notanda
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Hreyfi bílinn áfram 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Sný bílnum
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
