using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondicionaisCombinadas : MonoBehaviour
{

    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cylinder;
    
    //inserindo um rigid body na variavel, mas precisa ter o
    //componente no obj inserido na uniy para poder setar no inspector

    [SerializeField] Rigidbody _cubeRig;
    [SerializeField] Rigidbody _sphereRig;
    [SerializeField] Rigidbody _capsuleRig;
    [SerializeField] Rigidbody _cylindeRig;

    //pegando a caixa de colisao via codigo e inserindo em uma variavel
    [SerializeField] BoxCollider _cubeBox;
    [SerializeField] BoxCollider _sphereBox;
    [SerializeField] BoxCollider _capsuleBox;
    [SerializeField] BoxCollider _cylindeBox;

    [SerializeField] string _text;
    [SerializeField] float _number;
    [SerializeField] bool _check;

    // Start is called before the first frame update
    void Start()
    {
        //atribuindo a caixa de colisao ao cubo
        _cubeBox = _cube.GetComponent<BoxCollider>();
        
        if (_cubeBox != null) {
            _cubeBox.enabled = false;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * se check for true e number = 1 ativar o cubo
         * && = e
         * senao, se check = true e number = 2, desativar todos e ativar somente a esfera
        */

        if (_check == true && _number == 1) {
            _cube.SetActive(true);
            _cubeRig.useGravity = false;
            _cubeRig.isKinematic = true;

            _sphere.SetActive(false);
            _capsule.SetActive(false);
            _cylinder.SetActive(false);
        } else if(_check == true && _number == 2) {
            _cube.SetActive(false);
           
            _sphere.SetActive(true);
            _sphereRig.useGravity = false;

            _capsule.SetActive(false);
            _cylinder.SetActive(false);
        }
   

    }
}
