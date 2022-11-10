using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class ChangePv : MonoBehaviour
{
    // Start is called before the first frame update
    public float pv = 20f;
    public float maxPv = 20f;
    public float taille;
    void Start()
    {
        taille = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.localScale = new Vector3(pv * taille / maxPv, 1, 0.05f);
    }
}
