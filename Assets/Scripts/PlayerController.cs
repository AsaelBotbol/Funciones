using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    public bool isAble;
    public GameObject prefab;

    void Start()
    {
        isAble = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += new Vector3(0, 0, speed);
            transform.Translate(0, 0, speed); //para que vaya hacia adelante
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.position -= new Vector3(0, 0, speed);
            transform.Translate(0, 0, -speed); //para que vaya hacia atras
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, rotationSpeed, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles -= new Vector3(0, rotationSpeed, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clon;
            clon = Instantiate(prefab);
            clon.transform.position = transform.position - new Vector3(0, 0, 0);

        }
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "EnablerCube")
        {
            isAble = true;
        }
        else if (col.gameObject.name == "DisablerCube")
        {
            isAble = false;
        }
    }
}
