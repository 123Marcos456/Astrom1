using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPlayer : MonoBehaviour
{
    public float velocidad = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Cuando se actualiza el objeto
    void Update()
    {
        //Izquierda
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position += Vector3.left * velocidad * Time.deltaTime;
        }
        //Derecha
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position += Vector3.right * velocidad * Time.deltaTime;
        }
        //Arriba
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.position += Vector3.up * velocidad * Time.deltaTime;
        }
        //Abajo
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.position += Vector3.down * velocidad * Time.deltaTime;
        }
        //Adelante
        if(Input.GetKey(KeyCode.A)){
            transform.position += Vector3.forward * velocidad * Time.deltaTime;
        }
        //Atras
        if(Input.GetKey(KeyCode.S)){
            transform.position += Vector3.back * velocidad * Time.deltaTime;
        }

    }
}
