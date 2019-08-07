using UnityEngine;

namespace Controller
{
    public class PanzerShootController : MonoBehaviour
    {
        public GameObject ballPrefab;
        public GameObject ballObj;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //撃て
                GameObject g = Instantiate(ballPrefab, ballObj.transform);
                //戦車の位置
                g.transform.position = transform.position + new Vector3(0 , 0.5f, 0);

                int force = CreateForce();
                g.GetComponent<Rigidbody>().AddForce((transform.forward)* force);
            }
        }

        int CreateForce()
        {
            return 5000;
        }
    }
}
