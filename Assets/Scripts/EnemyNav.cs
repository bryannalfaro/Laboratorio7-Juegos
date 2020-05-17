using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Referencia video de clase y youtube
//Autor: Bryann Alfaro

public class EnemyNav : MonoBehaviour
{
    public Transform posicionInicial;
    public Transform posicion2;
    public Transform posicion3;

    private NavMeshAgent agenteEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        agenteEnemigo = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Se establecen los moivimientos del enemigo entre los puntos
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "1")
        {
            agenteEnemigo.SetDestination(posicion2.position);
        }
        if (other.tag == "2")
        {
            agenteEnemigo.SetDestination(posicion3.position);
        }
        if (other.tag == "3")
        {
            agenteEnemigo.SetDestination(posicionInicial.position);
        }

    }
}
