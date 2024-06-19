using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using misiones;

namespace misiones
{
    public class MissionManager : MonoBehaviour
    {
        //variable de script de mision
        public Player PlayerStats;//variable de script de jugador
        //variable q guarde suma ?
        public int vida;
        public int oro;
        public int sigilo;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Activar()
        {
            //llamar variable de script de la mision y sumarle eso a la variable de este script q guarde la suma
            PlayerStats.VIDA = PlayerStats.VIDA + vida;
            PlayerStats.ORO = PlayerStats.ORO + oro;
            PlayerStats.SIGILO = PlayerStats.SIGILO + sigilo;
            DesactivarMision();
        }

        public void DesactivarMision()
        {

        }

        public void CancelarMision()
        {

        }
    }
}
