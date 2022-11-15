using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorEscenas : MonoBehaviour
{
    public static void toEscenaInicio(){
        SceneManager.LoadScene("Inicio");
    }
    public static void toEscenaMenu(){
        SceneManager.LoadScene("Menu");
    }
    public static void toEscenaPlanetas(){
        SceneManager.LoadScene("Planetas");
    }
    public static void toEscenaTierra(){
        SceneManager.LoadScene("Tierra");
    }
}
