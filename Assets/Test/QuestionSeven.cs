using TMPro;
using UnityEngine;

namespace Test
{
    public class QuestionSeven : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private TextMeshProUGUI textSpeed;
        public float SpeedBetterOrNot
        {
            get { return speed; }
            set { speed = value; }
        }

        public void RandomSpeed()
        {
            var i = Random.Range(0, 100);
            SpeedBetterOrNot=i;
            textSpeed.text="Speed: "+i;
        }
    }
}