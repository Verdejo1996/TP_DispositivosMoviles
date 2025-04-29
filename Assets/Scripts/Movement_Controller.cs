
using Unity.VisualScripting;
using UnityEngine;



public class TouchMove : MonoBehaviour

{

    public GameObject objetoUI;

    public float velocidad = 500f;



    private Vector2 destino;



    void Start()

    {

    }



    void Update()

    {

        if (Input.touchCount > 0)

        {

            Touch toque = Input.GetTouch(0);



            if (toque.phase == TouchPhase.Began || toque.phase == TouchPhase.Moved)

            {


            }

        }

    }

}