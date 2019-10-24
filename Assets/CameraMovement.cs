using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;

    //Variable para mover la camara
    [Range(-10, 0)]
    public int offset_x;

    [Range(0, 10)]
    public int offset_y;

    [Range(0, 10)]
    public int offset_z;

    //Variables para controlar la transparencia de los objetos que impiden ver el personaje
    //¿Haria falta que las variables fueran un array por si hay mas de un objeto tapando al personaje?
    private Material material = null;   // Material que se quiere transparentar o opacar
    private Color32 color;              // Color del que se quiere pintar
    private byte alpha = 0;             // Canal alpha del material
    private bool transparente = false;  // Esta el objeto en transparente o opaco

    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position + new Vector3(offset_x, offset_y, offset_z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(offset_x, offset_y, offset_z);

        RaycastHit hit;
        //Comprobamos que no haya ningun objeto en el medio
        //Para ello trazamos una linea desde la vista del enemigo hasta la posicion del jugador
        if (Physics.Linecast(this.transform.position, player.transform.position, out hit))
        {
            //Si colisiona con el jugador eso significa que no hay obstaculos en el medio y por lo tanto lo hemos encontrado
            if (!hit.transform.CompareTag("Player"))  //TODO: comprobar que tampoco son enemigos ni el rey
            {
                //Obtenemos el material del objeto que nos tapa al jugador
                material = hit.transform.gameObject.GetComponent<MeshRenderer>().material;
          
                if (material != null && !transparente) //Si tiene material y aun no lo transparentamos
                {
                    color = material.GetColor("_Color");
                    alpha = color.a;
                    color.a = 20;
                    material.SetColor("_Color", color);
                    transparente = true;
                }
            }
            else
            {
                if (transparente) //Cuando dejemos de verlo lo volvemos a poner a su color original
                {
                    color.a = alpha;
                    material.SetColor("_Color", color);
                    material = null;
                    transparente = false;
                }
            }
        }

    }
}
