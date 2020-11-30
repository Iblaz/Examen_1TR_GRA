using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    
    [SerializeField] float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Método para mover la nave con el joystick
        MoverNave();
    }
    
    void MoverNave()
    {
        float desplZ = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");
        float PosX = transform.position.x;
        float PosZ = transform.position.z;

        //Eje X

        if (PosX > -9.5 && PosX < 9.5 || PosX < -9.5 && desplX > 0 || PosX > 9.5 && desplX < 0)
        {       
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }

        //Método de permitir movimiento contrario para corregir error en eje X

        //Eje Y

        if (PosZ > -9.5 && PosZ < 9.5 || PosZ < -9.5 && desplZ > 0 || PosZ > 9.5 && desplZ < 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);
        }

        //Método de permitir movimiento contrario para corregir error en eje Y
    }
}
