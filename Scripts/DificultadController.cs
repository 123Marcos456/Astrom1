using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DificultadController : MonoBehaviour
{
    //variables dropdown dificultad
    public int dificultad;
    public TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        //dropdown dificultad
        dificultad = PlayerPrefs.GetInt("nivelDificultad", 1);
        dropdown.value = dificultad;
        setDificultad();        
    }

    public void setDificultad(){
        PlayerPrefs.SetInt("nivelDificultad", dropdown.value);
        dificultad = dropdown.value;
        Debug.Log("Dificultad: "+dropdown.value);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

}
