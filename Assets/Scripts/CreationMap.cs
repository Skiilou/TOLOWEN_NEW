using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class CreationMap : MonoBehaviour
{
    public int monde;
    public int longueur;
    public int largeur;
    int x, y, point;
    public GameObject parent;
    public List<GameObject> terrain1;
    public GameObject bordure;
    public List<GameObject> terrain2;
    public List<GameObject> terrain3;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = longueur * -1 - 10; i < longueur + 10; i++)
        {
            for (int j = largeur * -1 - 10; j < largeur + 10; j++)
            {

                if ((i > longueur * -1 && i < longueur) && (j > largeur * -1 && j < largeur))
                {
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
                }
                else
                {
                    Instantiate(bordure, new Vector3(i * 2, 0, j * 2), Quaternion.identity, parent.transform);
                }
            }
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}