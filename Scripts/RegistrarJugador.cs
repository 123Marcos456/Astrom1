using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
// using UnityEngine.UI;

public class RegistrarJugador : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
    public TMP_InputField nombre_completo;
    public TMP_InputField nickname;
    public TMP_Dropdown edad;

    //para login
    public TMP_InputField nick_login;
    // public GameObject PanelLogin;
    // public GameObject PanelMenu;
    public TMP_Text MensajeLogin;



    public void guardar_jugador(){

        Jugador j = new Jugador();
        j.nombre = nombre_completo.text;
        j.nick = nickname.text;
        j.edad = edad.value;
        // j.setPuntaje(0);

        Registro reg = JsonUtility.FromJson<Registro>(PlayerPrefs.GetString("registro_jugadores", "{\"jugadores\":[]}"));

        if(!reg.existe_jugador(j.nick)){
            reg.agregar_jugador(j);
        }else{
            Debug.Log("El jugador ya existe");
        }

        // reg.agregar_jugador(j);
        // reg.vaciar();

        Debug.Log(JsonUtility.ToJson(reg));
        PlayerPrefs.SetString("registro_jugadores", JsonUtility.ToJson(reg));

        // Debug.Log(JsonUtility.ToJson(j));
        // PlayerPrefs.SetString("jugador", JsonUtility.ToJson(j));

    }

    // public void validar_jugador(){
    //     Jugador j = JsonUtility.FromJson<Jugador>(PlayerPrefs.GetString("jugador", ""));
    //     string n = nick_login.text;
    //     if(j.nick == n){
    //         // PanelLogin.SetActive(false);
    //         // PanelMenu.SetActive(true);
    //         SceneManager.LoadScene("Menu");
    //         Debug.Log("Identificado, ingresando a menu de usuario");
    //     }else{
    //         MensajeLogin.text = "Jugador no registrado, intenta nuevamente.";
    //         Debug.Log("Desconocido");
    //     }
    // }

    public void validar_jugador(){
        string n = nick_login.text;

        Registro reg = JsonUtility.FromJson<Registro>(PlayerPrefs.GetString("registro_jugadores", "{\"jugadores\":[]}"));

        if(!reg.existe_jugador(n)){
            SceneManager.LoadScene("Menu");
            Debug.Log("Identificado, ingresando a menu de usuario");
        }else{
            MensajeLogin.text = "Jugador no registrado, intenta nuevamente.";
            Debug.Log("Desconocido");
        }

    }



}

[System.Serializable]
public class Registro{
    public List <Jugador> jugadores;
    
    public void agregar_jugador(Jugador x){
        jugadores.Add(x);
        // int cant = 0;
        // jugadores = new Jugador[1];
        // jugadores[cant] = x;
    }

    public bool existe_jugador(string n){
        int cont = 0;
        if(jugadores.Count == 0){
            return false;
        }else{
            foreach(Jugador j in jugadores){
                // Debug.Log("Comparando:"+j.nick+" con "+n);
                if(String.Equals(j.nick, n, StringComparison.OrdinalIgnoreCase)){
                    cont++;
                }
            }
            if(cont > 0){
                return true;
            }    
            return false;
        }
    }

    public void vaciar(){
        jugadores.Clear();
    }


}

[System.Serializable]
public class Jugador{
    public string nombre;
    public string nick;    
    public int edad;
    public List<Puntaje> puntajes;

    public Jugador(){
        puntajes = new List<Puntaje>();
    }

    public void setPuntaje(int p){
        Puntaje x = new Puntaje();
        x.fecha = DateTime.Now.ToString();
        x.puntaje = p;
        // string cad = JsonUtility.ToJson(x);
        // int tam = puntajes.Count;                
        puntajes.Add(x);
    }
}

[System.Serializable]
public class Puntaje{
    public string fecha;
    public int puntaje;    
}
