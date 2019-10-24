using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public Transform enemy;

    public float distancia_de_vista = 10f; //TODO: cambiar nombre variable a inglés
    public float speed = 1.5f;
    public float distancia_de_golpeo = 2f; //TODO: cambiar nombre variable a inglés

    public EnemyState state;

    // Start is called before the first frame update
    void Start()
    {
        state = new EnemyStateStop(this);
    }

    // Update is called once per frame
    void Update()
    {
        state.stateUpdate();
    }

    public void moveToPlayer()
    {
        Vector3 direction = player.transform.position - enemy.transform.position;
        enemy.transform.position = enemy.transform.position + direction.normalized * speed * Time.deltaTime;
    }
}
