using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffreVoiture 
{

        private float capacite;
        //d�finition du constructeur par d�faut
        public CoffreVoiture()
        {
            Debug.Log(" Le coffre de la voiture a �t� cr��");
            capacite = 0;
        }
        //d�finition du constructeur alternatif
        public CoffreVoiture(float X)
        {
            capacite = X;
            Debug.Log("Coffre de \r\nla voiture a �t� cr�� avec l�argument suivant : " + X);
        }

    ~CoffreVoiture()
    { //d�finition du destructeur

         Debug.Log(" le coffre de la voiture sera maintenant d�truit!");

    }

}
