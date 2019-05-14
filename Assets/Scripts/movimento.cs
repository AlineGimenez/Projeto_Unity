using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    //variáveis para movimentação
    public float vel = 6f;

    //variáveis para joysticker
    [SerializeField]
    private int direcao = 0;

    //variável para animação
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        mov();
        //Mover();//joysticker
    }

    void mov()
    {
    
        //animação
        //anim.SetFloat("Speed", vel);

        /*if (Input.GetKey(KeyCode.RightArrow))//esquerda
        {
            transform.eulerAngles = new Vector2(0, 0);
            transform.Translate(new Vector3(vel * Time.deltaTime, 0, 0));
        }

        else if (Input.GetKey(KeyCode.LeftArrow))//direita
        {
            transform.eulerAngles = new Vector2(0, 180);
            transform.Translate(new Vector3(vel * Time.deltaTime, 0, 0));
        }*/

        if (Input.GetKey(KeyCode.UpArrow))//para cima
        {
            vel = 10f;
            transform.Translate(new Vector3(0, vel * Time.deltaTime, 0));
        }

        else if (Input.GetKey(KeyCode.DownArrow))//para baixo
        {
            transform.Translate(new Vector3(0, vel * Time.deltaTime, 0));
        }

        else if (Input.GetKey(KeyCode.Space))//para cima
        {
            vel = 10f;
            transform.Translate(new Vector3(0, vel * Time.deltaTime, 0));
        }


        //através de axis
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //animação
        anim.SetFloat("Speed", Mathf.Abs(horizontal));

        transform.eulerAngles = new Vector2(0, 0);//virar para direira

        transform.Translate(new Vector3(vel * horizontal * Time.deltaTime, vertical * Time.deltaTime, 0));

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector2(0, 180);//virar para esquerda
        }
    
    }


    //joysticker
    /*public void Direita()
    {
        direcao = 2;
    }

    public void Esquerda()
    {
        direcao = -2;
    }

    public void Parado()
    {
        direcao = 0;
    }

    void Mover()
    {
        transform.Translate(direcao*Time.deltaTime, 0, 0);
    }*/
}
