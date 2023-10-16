using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.Port;

public class CycleVie : MonoBehaviour

{
    public CoffreVoiture coffrevoiture;
    public float vitesse;
    // Start is called before the first frame update
    public CycleVie()
    {
        Debug.Log("La voiture se réveille ");
        Debug.Log("La voiture finit son \r\nparamétrage juste avant son utilisation");
        vitesse = 0;
        coffrevoiture= new CoffreVoiture();
    }
    public CycleVie(float X, CoffreVoiture Y)
    {
        vitesse = X;
        coffrevoiture = Y;
        Debug.Log("La voiture finit son \r\nparamétrage juste avant son utilisation");
    }
    private void OnDestroy()
    {
        
    }
    void Start()
    {
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.J))
        {
            Debug.Log(" La voiture est en voie de destruction");
            Destroy(gameObject);
        }
    }
}
