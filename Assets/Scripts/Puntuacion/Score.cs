using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace interfaz
{

    public class Score : MonoBehaviour
    {
        public float puntos;
        public TextMeshProUGUI Contador;
        void Update()
        {
            //ActualizarPuntaje();

        }

        public void ActualizarPuntaje(float ObjetoPuntos)
        {
            puntos = puntos + ObjetoPuntos;
            Contador.text = puntos + " puntos"; //capaz habria q sacar esto de acá y moverlo a un script q no tenga prefab!!!
            //Destroy(gameObject);
        }
    }
}
