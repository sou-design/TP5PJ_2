using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffreVoiture 
{

        private float capacite;
        //définition du constructeur par défaut
        public CoffreVoiture()
        {
            Debug.Log(" Le coffre de la voiture a été créé");
            capacite = 0;
        }
        //définition du constructeur alternatif
        public CoffreVoiture(float X)
        {
            capacite = X;
            Debug.Log("Coffre de \r\nla voiture a été créé avec l’argument suivant : " + X);
        }

    ~CoffreVoiture()
    { //définition du destructeur

         Debug.Log(" le coffre de la voiture sera maintenant détruit!");

    }

}
