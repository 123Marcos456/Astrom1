using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventApp : MonoBehaviour
{
    public void Salir(){
       Debug.Log("Saliendo de la aplicación");
        Application.Quit();
    }

}
