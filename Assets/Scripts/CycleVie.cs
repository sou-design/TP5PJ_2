using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.Port;

public class CycleVie : MonoBehaviour
{
    public float CoffreVoiture = 3.5f;
    // Start is called before the first frame update
    public CycleVie()
    {
        Debug.Log("La voiture se r�veille ");
        Debug.Log("La voiture finit son \r\nparam�trage juste avant son utilisation");
    }
    public CycleVie(float X)
    {
        CoffreVoiture = X;
        Debug.Log("La voiture finit son \r\nparam�trage juste avant son utilisation");
    }
    //~CycleVie()
    //{ //d�finition du destructeur
        
    //        Debug.Log(" La voiture est en voie de destruction");
    //}
    private void OnDestroy()
    {
        if (Input.GetKeyUp(KeyCode.J))
        {
            Debug.Log(" La voiture est en voie de destruction");
        }
    }
}
