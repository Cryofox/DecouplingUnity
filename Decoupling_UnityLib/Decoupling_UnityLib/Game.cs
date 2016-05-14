

using UnityEngine;
using Decoupling_UnityLib.Model;
namespace Decoupling_UnityLib
{
    public class Game : MonoBehaviour
    {
        public void Awake() { }
        public void Start()
        {
            new World();
        }
        public void Update(){ }


    }
}
