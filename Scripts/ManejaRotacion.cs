using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejaRotacion : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    public float speed = 30;

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.up);
    }
}
