using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Referencia video de clase
//Autor: Bryann Alfaro

public class NavMovimiento : MonoBehaviour
{
    public GameObject wp;
    private NavMeshAgent agenteJugador;

    // Start is called before the first frame update
    void Start()
    {
        
        agenteJugador = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            NavMeshHit navHitInfo;

            if (Physics.Raycast(myRay, out hitInfo) && NavMesh.SamplePosition(hitInfo.point, out navHitInfo, 0.1f, NavMesh.AllAreas))
            {
                agenteJugador.SetDestination(navHitInfo.position);            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Respawn"))
        {
            Destroy(gameObject);
        }
    }


}
