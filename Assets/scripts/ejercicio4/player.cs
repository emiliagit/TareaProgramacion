using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float moveSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputZ = Input.GetAxis("Vertical");
        float inputX = Input.GetAxis("Horizontal");

        Vector3 movimiento = new Vector3(inputX, 0f, inputZ) * moveSpeed * Time.deltaTime;

        transform.Translate(movimiento);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Misiones"))
        {
           
            Destroy(collision.gameObject);
        }
    }
}
