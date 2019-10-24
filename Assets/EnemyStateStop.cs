using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateStop : EnemyState
{
    private EnemyController enemy_controller;

    public EnemyStateStop(EnemyController enemy_controller)
    {
        this.enemy_controller = enemy_controller;
    }

    public override void stateUpdate()
    {
        if (encontrarJugador())
        {
            enemy_controller.state = new EnemyStateFollow(enemy_controller);
        }
    }

    private bool encontrarJugador()
    {
        //Si esta dentro de la distancia de vision del enemigo seguimos comprobando si lo encontramos
        if (Vector3.Distance(enemy_controller.transform.position, enemy_controller.player.position) < enemy_controller.distancia_de_vista)
        {
            RaycastHit hit;
            //Comprobamos que no haya ningun objeto en el medio
            //Para ello trazamos una linea desde la vista del enemigo hasta la posicion del jugador
            if (Physics.Linecast(enemy_controller.transform.position, enemy_controller.player.position, out hit))
            {
                //Si colisiona con el jugador eso significa que no hay obstaculos en el medio y por lo tanto lo hemos encontrado
                if (hit.transform.CompareTag("Player"))
                {
                    return true;
                }
            }
        }
        return false;
    }
}
