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
        [SerializeField]
        private int speed;


        public int Speed { get => this.speed; }

        private void Awake()
        {
            this.Initialized();
        }


        private void Initialized()
        {
            if(this.angle < 1)
            {
                this.angle = 1;
            }
        }

        //Se invoca la primera vez cuando se activa el GameObject

        // Update is called once per frame
        private void Update()
        {
            ((IMoveable)this).Move();
            ((IMoveable)this).Rotate();
        }
        void IMoveable.Move()
        {
            base.transform.position += new Vector3(Speed, 0, 0);
            if (base.transform.position.x > 100)
            {
                base.transform.position = new Vector3(0, 0, 0);
            }
            System.Threading.Thread.Sleep(50);
        }

        void IMoveable.Rotate()
        {
            base.transform.Rotate(Vector3.forward, angle);
        }
    }
}
