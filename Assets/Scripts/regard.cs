using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class regard : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform objet_cible;
    public Vector3 offset;
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = objet_cible.position + offset;
    }
}
