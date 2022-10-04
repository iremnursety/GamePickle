using UnityEngine;

namespace Test
{
    public class QuestionTen : MonoBehaviour
    {
        public static QuestionTen Instance { get; set; }
        
        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }
        
        /*
        With use 19th line we can call Test() from another scripts.
        QuestionTen.Intance.Test();
         
        public void Test()
        {
            
        }*/
    }
}
