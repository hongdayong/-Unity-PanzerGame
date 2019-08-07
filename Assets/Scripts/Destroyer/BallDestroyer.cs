using System;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

namespace Destroyer
{
    public class BallDestroyer : MonoBehaviour
    {

        public GameObject explosionPrefab;
        
        private void OnCollisionEnter(Collision other)
        {
            //戦車じゃない場合は砲弾を消滅する
            if (Tags.isNotPlayer(other.gameObject))
            {
                GameObject g = Instantiate(explosionPrefab);
                g.transform.position = gameObject.transform.position;
                Destroy(gameObject);
            }
        }
    }
}
