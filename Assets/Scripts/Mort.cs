using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mort : MonoBehaviour
{
    // Start is called before the first frame update
    public float vie;
    public GameObject barreDeVie;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vie = barreDeVie.GetComponent<ChangePv>().pv;
        if(vie <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Mort");
        }
    }
}
