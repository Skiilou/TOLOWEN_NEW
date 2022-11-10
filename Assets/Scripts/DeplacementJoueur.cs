using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class DeplacementJoueur : MonoBehaviour
{
    // Start is called before the first frame update
    //public Vector3 test;
    public Quaternion debutRotation;//Position de départ
    public float temps;
    //Faire une variable " position " de type int qui va aller de 1 à 4 . Si 1 ça veut dire que le panda est tourné à droite. Je vais faire mes déplacements sur ça 
    public int position;//1=haut 2=droite 3=bas 4=gauche
    
    void Start()
    {
        debutRotation = gameObject.transform.rotation;
        position = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // GAUCHE 270 HAUT 0 DROITE 90 BAS 180---EULER ANGLE.Y
        
        //gameObject.transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 10, 0f, 0f);//qd
        //gameObject.transform.Translate(0f, 0f, Input.GetAxis("Vertical") * Time.deltaTime * 10);//zs
        //gameObject.transform.Rotate(0f, Input.GetAxis("Horizontal") * Time.deltaTime * 1000, 0f);
        // ROTATION GAUCHE --------------------
        //Si le panda regarde en haute et appuie sur q il tourne à gauche
        if ((Input.GetKeyDown("q"))&&((gameObject.transform.eulerAngles.y)==0))
        {
            gameObject.transform.Rotate(0f, -90f, 0f);
            position = 4;
        }
        //Panda regarde en bas et la tourne à gauche
        if ((Input.GetKeyDown("q")) && ((gameObject.transform.eulerAngles.y) > 179 && (gameObject.transform.eulerAngles.y) < 181))
        {
            gameObject.transform.Rotate(0f, 90f, 0f);
            position = 4;
        }
        //Si le panda regarde à droite et qu'on appuie sur q il le retourne
        if ((Input.GetKeyDown("q")) && ((gameObject.transform.eulerAngles.y) == 90))
        {
            gameObject.transform.Rotate(0f, -180f, 0f);
            position = 4;


        }
        //ROTATION DROITE----------------
        //Si le panda regarde en haut et appuie sur d il tourne à droite
        if ((Input.GetKeyDown("d")) && ((gameObject.transform.eulerAngles.y) == 0))
        {
            gameObject.transform.Rotate(0f, 90f, 0f);
            position = 2;


        }
        //Panda regarde en bas et le tourne à droite
        if ((Input.GetKeyDown("d")) && ((gameObject.transform.eulerAngles.y)>179 &&(gameObject.transform.eulerAngles.y)<181))
        {
            gameObject.transform.Rotate(0f, -90f, 0f);
            position = 2;
        }
        // Si panda regarde gauche et appuie sur d le retourne
        if ((Input.GetKeyDown("d")) && ((gameObject.transform.eulerAngles.y) == 270))
        {
            gameObject.transform.Rotate(0f, 180f, 0f);
            position = 2;


        }
        //ROTATION HAUT
        //Si panda regarde gauche et appuie sur z le tourne vers le haut
        if ((Input.GetKeyDown("z")) && ((gameObject.transform.eulerAngles.y) == 270))
        {
            //gameObject.transform.Rotate(0f, 90f, 0f);
            //Ces deux lignes sont utiles pour reset la rotation de l'objet parce que sinon l'angle a une valeur bizarre------------------
            transform.rotation = Quaternion.Slerp(debutRotation, Quaternion.identity, temps);
            temps += Time.deltaTime;
            position = 1;


        }
        //Si panda regarde gauche et appuie sur z le tourne vers le haut
        if ((Input.GetKeyDown("z")) && ((gameObject.transform.eulerAngles.y) > 179 && (gameObject.transform.eulerAngles.y) < 181))//
        {
            //gameObject.transform.Rotate(0f, 90f, 0f);
            //Ces deux lignes sont utiles pour reset la rotation de l'objet parce que sinon l'angle a une valeur bizarre------------------
            transform.rotation = Quaternion.Slerp(debutRotation, Quaternion.identity, temps);
            temps += Time.deltaTime;
            position = 1;


        }
        //Si panda regarde droite et appuie sur z le tourne vers le haut
        if ((Input.GetKeyDown("z")) && ((gameObject.transform.eulerAngles.y) == 90))
        {
            //gameObject.transform.Rotate(0f, -90f, 0f);
            transform.rotation = Quaternion.Slerp(debutRotation, Quaternion.identity, temps);
            temps += Time.deltaTime;
            position = 1;
        }
        //ROTATION BAS
        //Panda regarde à droite appuie sur s pour regarder en bas
        if ((Input.GetKeyDown("s")) && ((gameObject.transform.eulerAngles.y) == 90))
        {
            gameObject.transform.Rotate(0f, 90f, 0f);
            position = 3;


        }
        //Panda regarde en haut et le retourne
        if ((Input.GetKeyDown("s")) && ((gameObject.transform.eulerAngles.y) == 0))
        {
            gameObject.transform.Rotate(0f, 180f, 0f);
            position = 3;


        }
        //Panda regarde à gauche appuie sur s pour regarder en bas
        if ((Input.GetKeyDown("s")) && ((gameObject.transform.eulerAngles.y) == 270))
        {
            gameObject.transform.Rotate(0f, -90f, 0f);
            position = 3;


        }

        //DEPLACEMENT--------------------------
        //bon
        if (Input.GetKey("z"))
        {
            gameObject.transform.Translate(0f, 0f, Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            gameObject.transform.Translate(0f, 0f, Time.deltaTime);
        }
        //bon
        if (Input.GetKey("s"))
        {
            gameObject.transform.Translate(0f, 0f, Time.deltaTime);
        }
        if (Input.GetKey("q"))
        {
            gameObject.transform.Translate(0f, 0f, Time.deltaTime);
        }
        
        //haut droite
        if (((Input.GetKey("z")) && (Input.GetKey("d")))&&(position==1))
            {
            gameObject.transform.Translate(Time.deltaTime, 0f, Time.deltaTime);
            print("haut droite");
        }
        if (((Input.GetKey("z")) && (Input.GetKey("d"))) && (position == 2))
        {
            gameObject.transform.Translate(Time.deltaTime*(-1), 0f, Time.deltaTime);
            print("haut droite");
        }
        //haut gauche
        if (((Input.GetKey("z")) && (Input.GetKey("q"))) && (position == 1))
        {
            gameObject.transform.Translate(Time.deltaTime, 0f, Time.deltaTime * (-1));
            print("haut gauche");
        }
        if (((Input.GetKey("z")) && (Input.GetKey("q"))) && (position == 4))
        {
            gameObject.transform.Translate(Time.deltaTime * (-1), 0f, Time.deltaTime);
            print("haut gauche");
        }
        /*
        if ((Input.GetKey("z")) && (Input.GetKey("q")))
        {
            gameObject.transform.Translate(0f, 0f, Time.deltaTime);
            print("haut gauche");
        }
        if ((Input.GetKey("s")) && (Input.GetKey("d")))
        {
            gameObject.transform.Translate(0f, 0f, Time.deltaTime);
            print("bas gauche");
        }
        if ((Input.GetKey("s")) && (Input.GetKey("q")))
        {
            gameObject.transform.Translate(0f, 0f, Time.deltaTime);
            print("bas droite");
        }
        */




        if (Input.GetKeyDown("a"))
        {
            //print(gameObject.transform.eulerAngles.x);
            
            print(gameObject.transform.eulerAngles.y);
            print(position);

        }
    }
}
/* 
 
 transform.rotation = Quaternion.Slerp(debutRotation, Quaternion.identity, temps);
            temps += Time.deltaTime;
 
 J'ai pu utiliser deux tricks pour que ça fonctionne : 
Faire pour que l'angle soit entre 179 et 180 parce que l'angle variait un petit peu quand je retournais mon objet
Ou alors reset l'angle du panda quand il retourne en haut mais ça fonctionne uniquement pour en haut
 
 
 
 */