using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private int _maxLife;
    private int _life;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Vector3 _direction;



    public int Life => _life;
    public float Speed => _speed;
    public Vector3 Direction => _direction;
    private void Awake()
    {
        Initialize();
    }
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        this.Displace();
    }


    private void Initialize()
    {
        this._life = this._maxLife;
    }

    private void Displace()
    {
        

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Para adelante");
            float x = base.transform.position.x + this.Speed;
            base.transform.position = new Vector3(x,base.transform.position.y, base.transform.position.z);
            
        }else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Para atras");
            float x = base.transform.position.x - this.Speed;
            base.transform.position = new Vector3(x, base.transform.position.y, base.transform.position.z);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Derecha");
            float z = base.transform.position.z + this.Speed;
            base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y, z);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Izquierda");
            float z = base.transform.position.z - this.Speed;
            base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y, z);
        }
        System.Threading.Thread.Sleep(500);
    }
    private void Damage()
    {
        if (this._life > 0)
        {
            this._life--;
            Debug.Log($"Dañando, valor actual {this._life}");
        }
    }
    private void Damage(int damage)
    {

        if ((this._life - damage) > 0)
        {
            this._life -= damage;
        }
        else
        {
            this._life = 0;
        }
        Debug.Log($"Dañando, valor actual {this._life}");
    }

    private void Cure()
    {
        if (this._life < 1)
        {
            this._life = this._maxLife;
            Debug.Log($"Sanando, valor actual {this._life}");
        }
    }
    private void Cure(int life)
    {
        if (this._life + life < this._maxLife)
        {
            this._life += life;
        }
        else
        {
            this._life = this._maxLife;
        }
        Debug.Log($"Sanando, valor actual {this._life}");
    }
}
