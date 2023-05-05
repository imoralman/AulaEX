using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaNumero : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cylinder;

    [SerializeField] int _numero;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){


        //ativando um objeto e desativando os outros

        if (_numero == 1) {
            _cube.SetActive(true);
            _sphere.SetActive(false);
            _capsule.SetActive(false);
            _cylinder.SetActive(false);
 
            } else if (_numero == 2) {
                        _sphere.SetActive(true);
                        _cube.SetActive(false);
                        _capsule.SetActive(false);
                        _cylinder.SetActive(false);

                } else if (_numero == 3) {
                          _capsule.SetActive(true);
                          _cube.SetActive(false);
                          _sphere.SetActive(false);
                          _cylinder.SetActive(false);
                   
                    } else if (_numero == 4) {
                                _cylinder.SetActive(true);
                                _cube.SetActive(false);
                                _sphere.SetActive(false);
                                _capsule.SetActive(false);

                            } else if (_numero < 1) {
                                   _cube.SetActive(false);
                                   _sphere.SetActive(false);
                                   _capsule.SetActive(false);
                                   _cylinder.SetActive(false);

                            }else {
                                 _cube.SetActive(true);
                                 _sphere.SetActive(true);
                                 _capsule.SetActive(true);
                                 _cylinder.SetActive(true);

                             }
                }
    }

    

