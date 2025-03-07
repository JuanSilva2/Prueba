using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panther : Animal
{
    //constructor propio de la clase Panther
    //es necesario porque hereda un constructor de animal
    //base:(...); sirve para pasarle la información a la clase padre Animal
    public Panther(string _nombre, int _edad, string _genero) : base(_nombre, _edad, _genero)
    {

    }

    public void Start()
    {
        Move();
    }

    public override void Move()
    {
        base.Move();
        Debug.Log("Pantera se mueve");
        //Pedazo de código que utiliza como base el código de Move de animal
        //Con la diferencia de que cambia el funcionamiento específico para Panther.
    }
}
