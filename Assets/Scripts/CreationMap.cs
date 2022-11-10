using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class CreationMap : MonoBehaviour
{

    public List<List<GameObject>> mondeGenerateur;
    public int monde;
    public int longueur;
    public int largeur;
    public int timer;
    public int money;
    int x, y, point;
    public GameObject parent;
    public GameObject thune;
    public GameObject bordure;
    public List<GameObject> terrain1;
    public GameObject bouffe1;
    public List<GameObject> terrain2;
    public GameObject bouffe2;
    public List<GameObject> terrain3;
    public GameObject bouffe3;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = longueur * -1 - 10; i < longueur + 10; i++)
        {
            for(int j = largeur * -1 - 10; j < largeur + 10; j++)
            {

                if ((i > longueur * -1 && i < longueur) && (j > largeur * -1 && j < largeur))
                {}
                else
                {
                    Instantiate(bordure, new Vector3(i * 2, 1.26337f + 0.01263374f, j * 2), Quaternion.identity, parent.transform);
                }


                if (monde == 1)
                {
                    point = Mathf.FloorToInt(8 * Mathf.PerlinNoise(i * 0.1f + Random.Range(0, 10000), j * 0.1f + Random.Range(0, 10000)));
                    switch (point)
                    {
                        case 0:
                            Instantiate(terrain1[0], new Vector3(i * 2, 0, j * 2), Quaternion.identity, parent.transform);
                            break;

                        case 1:
                            Instantiate(terrain1[1], new Vector3(i * 2, 0, j * 2), Quaternion.identity, parent.transform);
                            break;

                        case 2:
                            Instantiate(terrain1[2], new Vector3(i * 2, 0, j * 2), Quaternion.identity, parent.transform);
                            break;

                        default:
                            Instantiate(terrain1[3], new Vector3(i * 2, 0, j * 2), Quaternion.identity, parent.transform);
                            break;
                    }
                }
                if (monde == 2)
                {
                    point = Mathf.FloorToInt(8 * Mathf.PerlinNoise(i * 0.1f + Random.Range(0, 10000), j * 0.1f + Random.Range(0, 10000)));
                    switch (point)
                    {
                        case 0:
                            Instantiate(terrain2[0], new Vector3(i * 2, 0, j * 2), Quaternion.identity, parent.transform);
                            break;

                        case 1:
                            Instantiate(terrain2[1], new Vector3(i * 2, 0, j * 2), Quaternion.identity, parent.transform);
                            break;

                        case 2:
                            Instantiate(terrain2[2], new Vector3(i * 2, 0, j * 2), Quaternion.identity, parent.transform);
                            break;

                        default:
                            Instantiate(terrain2[3], new Vector3(i * 2, 0, j * 2), Quaternion.identity, parent.transform);
                            break;
                    }
                }

                if (monde == 3)
                {
                    point = Mathf.FloorToInt(8 * Mathf.PerlinNoise(i * 0.1f + Random.Range(0, 10000), j * 0.1f + Random.Range(0, 10000)));
                    switch (point)
                    {
                        case 0:
                            Instantiate(terrain3[0], new Vector3(i * 2, 0, j * 2), Quaternion.identity, parent.transform);
                            break;

                        case 1:
                            Instantiate(terrain3[1], new Vector3(i * 2, 0, j * 2), Quaternion.identity, parent.transform);
                            break;

                        case 2:
                            Instantiate(terrain3[2], new Vector3(i * 2, 0, j * 2), Quaternion.identity, parent.transform);
                            break;

                        default:
                            Instantiate(terrain3[3], new Vector3(i * 2, 0, j * 2), Quaternion.identity, parent.transform);
                            break;
                    }
                }
                
                
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        money++;
        if (money>=200)
        {
            Instantiate(thune, new Vector3(Random.Range((longueur - 2) * -2, (longueur - 2) * 2), 1, Random.Range((largeur - 2) * -2, (largeur - 2) * 2)), Quaternion.identity, parent.transform);
            money = 0;
        }
        timer++;
        if (timer>=1000)
        {
            switch (monde) {
                case 1:
                    Instantiate(bouffe1, new Vector3(Random.Range((longueur-2)*-2,(longueur-2)*2), 1, Random.Range((largeur-2) * -2, (largeur-2) * 2)), Quaternion.identity, parent.transform);
                    break;
                case 2:
                    Instantiate(bouffe2, new Vector3(Random.Range((longueur - 2) * -2, (longueur - 2) * 2), 1, Random.Range((largeur - 2) * -2, (largeur - 2) * 2)), Quaternion.identity, parent.transform);
                    break;
                case 3:
                    Instantiate(bouffe3, new Vector3(Random.Range((longueur - 2) * -2, (longueur - 2) * 2), 1, Random.Range((largeur - 2) * -2, (largeur - 2) * 2)), Quaternion.identity, parent.transform);
                    break;
            }
            timer = 0;
            
        }
    }
}
