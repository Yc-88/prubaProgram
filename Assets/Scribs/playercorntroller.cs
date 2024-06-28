using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercorntroller : MonoBehaviour
{
    public float velocidad = 5.0f;

    // Update is called once per frame
    void Update()
    {
        float horizontalimput = Input.GetAxis("Horizontal");

        Vector3 direccion = new Vector3(horizontalimput,0,0);

        transform.Translate(direccion * velocidad * Time.deltaTime);
    }
}
