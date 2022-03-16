using Assets.Scripts.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class CubeController : MonoBehaviour, IMoveable
    {
        [SerializeField]
        private int angle;
        private int speed;


        private void Awake()
        {
            this.Initialized();
        }


        private void Initialized()
        {
            if (this.angle < 1)
            {
                this.angle = 1;
            }
            this.speed = 1;
        }

        //Se invoca la primera vez cuando se activa el GameObject

        // Update is called once per frame
        private void Update()
        {
           ((IMoveable)this).Move();
        }
        void IMoveable.Move()
        {
            ((IMoveable)this).Rotate();
        }

        void IMoveable.Rotate()
        {
            base.transform.Rotate(Vector3.forward, angle);
        }
    }
}
