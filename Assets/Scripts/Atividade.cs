using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade : MonoBehaviour
{

    //declarar 3 classes de texto
    //implementar o valor somente na primeira
    
    
    //na funcao start
    //alterar a primeira variavel
    //concatenar a primeira e a seugunda na terceira variavel



    [SerializeField] string _nome1 = "qwert";
    [SerializeField] string _nome2;
    [SerializeField] string _nome3;
  
    void Start() {

        _nome1 = "asdf";
        _nome3 = _nome1 + " " + _nome2;

    }

 
    void Update()
    {
        
    }
}
