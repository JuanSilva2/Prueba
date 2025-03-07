using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZooAdmin : MonoBehaviour
{
    private Animal elefante;
    private Animal ornitorrinco;
    private Animal pantera;

    //Esta clase tiene una función que llama al constructor Animal, se llama igual que su clase, sirve 
    //para crear nuevos objetos, como plantillas de formularios

    private void Start()
    {
        
        elefante = new Animal("elefante", 19, "macho");
        ornitorrinco = new Animal("Ornitorrinco", 5, "Hembra");
        //elfante.nombre;

        pantera = new Panther("Pantera", 5, "Hembra");
        //Debug.Log(pantera.nombre);

        elefante.Move();
        ornitorrinco.Move();
        pantera.Move();
    }
}
