using UnityEngine;

namespace Test
{
    public class QuestionThree : MonoBehaviour
    {
        public int exampleInt;
        public float exampleFloat;
        public string exampleString;
        [SerializeField] private Quaternion exampleQuaternion;
        [SerializeField] private Transform exampleTransform;
        [SerializeField] private Vector3 exampleVector;
        [SerializeField] private GameObject exampleGameObject;

        private void Start()
        {
            ChangeVariables();
        }

        private void ChangeVariables()
        {
            exampleInt = 1;
            exampleFloat = 1.717171f;
            exampleString = "Hello Game Pickle";

            exampleQuaternion = new Quaternion(45f, 45f, 45f,0f );
            exampleVector = new Vector3(1, 1, 1);

            exampleGameObject = gameObject;
            exampleTransform = exampleGameObject.transform;

            exampleTransform.position = exampleVector;
            exampleTransform.rotation = exampleQuaternion;
            
            //Scale also talking 3 input for x ,y and z.
            exampleTransform.localScale = new Vector3(2,2,2);

        }
    }
}