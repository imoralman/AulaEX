using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaMenu : MonoBehaviour
{

    //variaveis para as telas de menu
    [SerializeField] GameObject Painel_inicial;
    [SerializeField] GameObject Painel_carregar;
    [SerializeField] GameObject Painel_personagem;

    public void AtivaPainelIniciar() {
        Painel_inicial.SetActive(true);
        Painel_carregar.SetActive(false);
        Painel_personagem.SetActive(false);
    }
    public void AtivaPainelCarregar() {
        Painel_inicial.SetActive(false);
        Painel_carregar.SetActive(true);
        Painel_personagem.SetActive(false);
    }
    public void AtivaPainelPersonagem() {
        Painel_inicial.SetActive(false);
        Painel_carregar.SetActive(false);
        Painel_personagem.SetActive(true);
    }




    /*
    void Start(){}
    void Update(){}
    */
}
