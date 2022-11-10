using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject terrainManager;
    public GameObject souris;
    public GameObject colliderActif;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        {
            //Debug.Log(mousePos.x);
            //Debug.Log(mousePos.y);
        }
        souris.transform.position = new Vector3((mousePos.x-(Screen.width/2))/50, 0, (mousePos.y-(Screen.height/2))/50);
        colliderActif = GameObject.Find("Mouse").GetComponent<MouseCollider>().colliderActif;

        if (Input.GetMouseButtonDown(0))
        {

            if (colliderActif.gameObject.name == btn1.name)
            {
                Instantiate(terrainManager, new Vector3(0, 0, 0), Quaternion.identity, GameObject.Find("Menu").transform);
                GameObject.Find("terrainManager(Clone)").GetComponent<CreationMap>().monde = 1;

            }

            if (colliderActif.gameObject.name == btn2.name)
            {
                Instantiate(terrainManager, new Vector3(0, 0, 0), Quaternion.identity, GameObject.Find("Menu").transform);
                GameObject.Find("terrainManager(Clone)").GetComponent<CreationMap>().monde = 2;
            }

            if (colliderActif.gameObject.name == btn3.name)
            {
                Instantiate(terrainManager, new Vector3(0, 0, 0), Quaternion.identity, GameObject.Find("Menu").transform);
                GameObject.Find("terrainManager(Clone)").GetComponent<CreationMap>().monde = 3;
            }
        }
    }




}
