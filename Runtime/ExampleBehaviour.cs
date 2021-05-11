using UnityEngine;

namespace cz.vysinsky.unity.examplepackage.runtime
{
    public class ExampleBehaviour : MonoBehaviour
    {

       public int ExampleProperty;

        private void Start()
        {
            Debug.Log("Log from ExampleBehaviour");
        }
    }
}
