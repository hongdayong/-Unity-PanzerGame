using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Controller
{
    public class PanzerMoveController : MonoBehaviour
    {
    
        private CharacterController controller;
        const float moveSpeed = 0.1f;
        private const float rotateSpeed = 60f;
    
        // Start is called before the first frame update
        void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.W))//Wキーがおされたら
            {
//                transform.rotation = Quaternion.Euler(0, 180, 0);//0°に向ける
                controller.Move (this.gameObject.transform.forward * moveSpeed);
            }
            
            if (Input.GetKey(KeyCode.S))
            {
                controller.Move(- this.gameObject.transform.forward * moveSpeed);
            }
            
            //A D は回転
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.down * Time.deltaTime * rotateSpeed);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
            }
        }

    }

}