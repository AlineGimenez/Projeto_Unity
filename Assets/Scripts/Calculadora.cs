using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculadora : MonoBehaviour
{
    Text txt, txt2, txt3, txt_result;
    int n1, n2, result;
    
    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("CampoText").GetComponent<UnityEngine.UI.Text>();//campo de texto
        txt2 = GameObject.Find("CampoText2").GetComponent<UnityEngine.UI.Text>();//campo de texto
        txt3 = GameObject.Find("CampoText3").GetComponent<UnityEngine.UI.Text>();//campo de texto
        txt_result = GameObject.Find("Resultado").GetComponent<UnityEngine.UI.Text>();//campo de texto
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addDigito(string digito) // adicionar o digito a tela
    {
        if (txt2.text.Equals(""))
        {
            if (txt.text.Length < 9)
            {
                txt.text = txt.text + digito;
            }
        }
        else
        {
            if (txt3.text.Length < 9)
            {
                txt3.text = txt3.text + digito;
            }
        }
    }

    public void aparecerCanvas(GameObject canvas) // aparecer o canvas quando clicado na calculadora
    {
        canvas.SetActive(true);
        //GameObject.Find("Canvas").SetActive(false);

    }

    public void desaparecerCanvas(GameObject canvas)
    {
        canvas.SetActive(false);
        //GameObject.Find("Canvas").SetActive(true);
        limpar();
    }

    public void limpar()
    {
        txt.text = "";
        txt2.text = "";
        txt3.text = "";
        txt_result.text = "";
    }

    public void soma()
    {
            txt2.text = "+";
    }

    public void sub()
    {
        txt2.text = "-";
    }

    public void multi()
    {
        txt2.text = "*";
    }

    public void divi()
    {
        txt2.text = "/";
    }

    public void igual()
    {
        if (txt2.text.Length < 9)
        {
            n1 = Convert.ToInt32(txt.text);
            n2 = Convert.ToInt32(txt3.text);

            switch (txt2.text)
            {
                case "+":
                    result = n1 + n2;
                    txt_result.text = "= "+ result ;
                    break;

                case "-":
                    result = n1 - n2;
                    txt_result.text = "= " + result;
                    break;

                case "*":
                    result = n1 * n2;
                    txt_result.text = "= " + result;
                    break;

                case "/":
                        if (n2 != 0)
                        {
                            result = n1 / n2;
                            txt_result.text = "= " + result;
                        }
                    break;
            }
        }
    }

    
}
