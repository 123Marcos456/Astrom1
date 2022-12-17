using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalidadController : MonoBehaviour
{
    //variables dropdown calidad
    public int calidad;
    public TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        //dropdown calidad
        calidad = PlayerPrefs.GetInt("nivelCalidad", 2);
        dropdown.value = calidad;
        setCalidad();        
    }

    public void setCalidad(){
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("nivelCalidad", dropdown.value);
        calidad = dropdown.value;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
