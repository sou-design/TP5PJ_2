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






//public Vector3 right;
    //public Vector3 left;
    //public Vector3 up;
    //public Vector3 down;
    //public float speed;
// Start is called before the first frame update
    //void Start()
    //{

    //   right = new Vector3(1, 0, 0);
    //   left = new Vector3(-1, 0, 0);
    //   up = new Vector3(0, 0, 1);
    //   down = new Vector3(0, 0, -1);
    //   speed = 1000;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKey("right"))
    //    {
    //        gameObject.transform.position = right + (gameObject.transform.position * speed * Time.deltaTime); 

    //    }
    //    if (Input.GetKey("left"))
    //    {
    //        gameObject.transform.position = left + (gameObject.transform.position * speed * Time.deltaTime);

    //    }
    //    if (Input.GetKey("up"))
    //    {
    //        gameObject.transform.position = up + (gameObject.transform.position * speed * Time.deltaTime); 

    //    }
    //    if (Input.GetKey("down"))
    //    {
    //        gameObject.transform.position = down + (gameObject.transform.position * speed * Time.deltaTime); 

    //    }
    //}
// Start is called before the first frame update

//private string RIGHT = "right";
//private string LEFT = "left";
//private string UP = "top";
//private string DOWN = "bottom";

//Vector3 vecteur = new Vector3(1, 0, 0);
//void FixedUpdate()
//{
//    if (Input.GetKey("w"))
//    {
//    gameObject.transform.position *= Time.deltaTime;
//    gameObject.transform.position += vecteur;
//    }
//}

// Update is called once per frame
//void Update()
//{
//    if (Input.GetKey("w"))
//    {
//    gameObject.transform.position *= Time.deltaTime;
//    gameObject.transform.position += vecteur;
//    }

//}