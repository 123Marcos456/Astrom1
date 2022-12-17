using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CargaPreferencias : MonoBehaviour
{
    public TMP_Text user_nick;
    // Start is called before the first frame update
    void Start()
    {
        Jugador j = JsonUtility.FromJson<Jugador>(PlayerPrefs.GetString("jugador", "{\"nombre\":\"\", \"nick\":\"\",\"edad\":\"0\",\"puntajes\":[12,23,45],}"));
        user_nick.text = j.nick;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
