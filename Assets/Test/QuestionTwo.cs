using UnityEngine;

namespace Test
{
    public class QuestionTwo : MonoBehaviour
    {
        [SerializeField] private GameObject cube1;
        [SerializeField] private GameObject cube2;
        [SerializeField] private float speed;
        void Start()
        {
            speed = 1f;
        }


        void Update()
        {
            Option1();
            Option2();
        }

        private void Option1()
        {
            var cubePos = cube1.transform.position;
            cube1.transform.position = new Vector3(cubePos.x, cubePos.y + speed, cubePos.z);
            
        }

        private void Option2()
        {
            cube2.transform.position +=Vector3.up*speed;
        }
    }
}