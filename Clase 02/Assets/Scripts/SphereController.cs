using Assets.Scripts.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour, IMoveable
{


    [SerializeField]
    private int speed;
    [SerializeField]
    private Vector3 positionInitial;
    [SerializeField]
    private Vector3 size;




    public int Speed { get => this.speed; }

    //Se invoca la primera vez cuando se activa el GameObject
    private void Awake()
    {
        this.Initialize();
    }

    // Start is called before the first frame update
    private void Start()
    {

    }
    // Update is called once per frame
    private void Update()
    {
        ((IMoveable)this).Move();
        
    }
    private void Initialize()
    {
        base.transform.localScale = this.size;
        base.transform.position = this.positionInitial;
    }

    void IMoveable.Move()
    {
        base.transform.position += new Vector3(Speed, 0, 0);
        if (base.transform.position.x > 100)
        {
            base.transform.position = this.positionInitial;
        }
        System.Threading.Thread.Sleep(50);
        ((IMoveable)this).Rotate();
    }

    public void Rotate()
    {
        base.transform.Rotate(base.transform.forward);
    }
}
