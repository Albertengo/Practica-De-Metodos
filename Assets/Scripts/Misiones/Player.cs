using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace misiones
{
    public class Player : MonoBehaviour
    {
        public TextMeshProUGUI textoVida;
        public TextMeshProUGUI textoOro;
        public TextMeshProUGUI textoSigilo;
        public int VIDA;
        public int ORO;
        public int SIGILO;

        private void Update()
        {
            textoVida.text = "" + VIDA;
            textoOro.text = "" + ORO;
            textoSigilo.text = "" + SIGILO;
        }
    }
}
