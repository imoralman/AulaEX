using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textos : MonoBehaviour
{

    [SerializeField] string _nome = "Norman";
    [SerializeField] string _sobreNome;
    [SerializeField] string _nomeCompleto;

    [SerializeField] Text _text;
  
    void Start() {

        _nome = "Hotel";
        _nomeCompleto = _nome + " " + _sobreNome;

        _text.text = _nomeCompleto;       

    }


    void Update() {
        
    }
}
