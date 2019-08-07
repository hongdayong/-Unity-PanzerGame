using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Destroyer
{
    public class SoftStoneDestroyer : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            //砲弾なら自分を消す
            if (Tags.isBall(other.gameObject))
            {
                Destroy(gameObject);
            }
        }
    }
}
