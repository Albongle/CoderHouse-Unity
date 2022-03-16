using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Interfaces
{
    public interface IMoveable
    {
        int Speed { get; }
        void Move();
        void Rotate();
    }
}
