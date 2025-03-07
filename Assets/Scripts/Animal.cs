using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    /*public int _hungerLimit=5;
    private int _consumeFood;

    private void Start()
    {
        Debug.Log(HasEat());
        Debug.Log(HasEat());
        Debug.Log(HasEat());
        Debug.Log(HasEat());
        Debug.Log(HasEat());
        Debug.Log(HasEat());

    }

    public bool HasEat()
    {
        _consumeFood += 1;
        if(_consumeFood>= _hungerLimit)
        {
            _consumeFood = 0;
            return true;
        }
        return false;
    }*/

    //Constructores
    private string nombre;
    private int edad;
    private string genero;
    public Animal(string _nombre, int _edad, string _genero)
    {
        nombre = _nombre;
        edad = _edad;
        genero = _genero;
    }

    //polimorfismo
    public virtual void Move()
    {
        Debug.Log("Animal se mueve");
        //Pedazo de codigo que genera el movimiento del animal cualquiera
    }
}
