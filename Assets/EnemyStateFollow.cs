using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateFollow : EnemyState
{
    private EnemyController enemy_controller;

    public EnemyStateFollow(EnemyController enemy_controller)
    {
        this.enemy_controller = enemy_controller;
    }

    public override void stateUpdate()
    {
        //Si el jugador se acerca lo atacamos TODO: Atacar
        if (Vector3.Distance(enemy_controller.transform.position, enemy_controller.player.position) < enemy_controller.distancia_de_golpeo)
        {
             return;
        }

        enemy_controller.moveToPlayer();
    }

 }
