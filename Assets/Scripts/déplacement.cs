using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
public class déplacement : MonoBehaviour
{
    [Range(0, 50)] public float vitesse;
    //Vector3 vecteur = new Vector3(0, 0, 1);
    //GestionVoiture Gvoiture=new GestionVoiture();
    void Update()
    {
        //if(GetComponent<GestionVoiture>().roule(0))
        //{ 
        //    gameObject.transform.position += vecteur * vitesse * Time.deltaTime; 
        //}
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.left, vitesse * Time.deltaTime);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            //gameObject.transform.position += new Vector3(1, 0, 0) * vitesse * Time.deltaTime; 
            transform.Rotate(Vector3.right, vitesse * Time.deltaTime);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            //gameObject.transform.position += new Vector3(0, 0, 1) * vitesse * Time.deltaTime; 
            transform.Translate(Vector3.forward * Time.deltaTime * vitesse);

        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            //gameObject.transform.position += new Vector3(0, 0, -1) * vitesse * Time.deltaTime; }
            transform.Translate(Vector3.back * Time.deltaTime * vitesse);

        }
    }

}       





