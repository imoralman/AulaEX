using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemplo : MonoBehaviour
{

    [SerializeField]int _numero;
    [SerializeField]string _texto, _texto2 =  "nao tem pizza";
    [SerializeField]bool _check;
    [SerializeField]float _fnumber; //numeros com decimais



    // Start is called before the first frame update
    void Start()
    {


        Debug.Log("valoe do numero e " +_numero);
        _numero = 2;
        Debug.Log("novo valor do numero " + _numero);

        _texto = "Pizza";
        Debug.Log("valor da string " + _texto);

        _texto = _texto2;
        Debug.Log("valor da string " + _texto);
        
        _check = true;
        Debug.Log("valor da boleana " + _check);


    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("valor da boleana " + _check);

    }
}
