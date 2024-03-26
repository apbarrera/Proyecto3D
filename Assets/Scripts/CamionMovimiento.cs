using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamionMovimiento : MonoBehaviour
{
    public float moveSpeed = 9f;
    public float rotationSpeed = 100f;
    public float forwardSpeed = 10f; // Velocidad constante hacia adelante

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Obtener la entrada de movimiento horizontal
        float rotateInput = Input.GetAxis("Horizontal");

        // Calcular la rotación del camión
        Quaternion rotation = Quaternion.Euler(0, rotateInput * rotationSpeed * Time.fixedDeltaTime, 0);
        rb.MoveRotation(rb.rotation * rotation);

        // Aplicar velocidad constante hacia adelante
        Vector3 moveDirection = transform.forward * forwardSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moveDirection);
    }
}
