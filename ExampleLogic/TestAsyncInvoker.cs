using System.Threading.Tasks;
using UnityEngine;

namespace ExampleLogic
{
    public class TestAsyncInvoker : MonoBehaviour
    {
        [SerializeField] private Transform _lagIndicator;

        private Vector3 _lagIndicatorRotation;
        private void Awake()
        {
            SomeLongMethod();
        }

        private void Update()
        {
            if(_lagIndicator == null)    
                return;
            _lagIndicatorRotation += Vector3.one;
            _lagIndicator.eulerAngles = _lagIndicatorRotation;
        }


        private async Task SomeLongMethod()
        {
            Debug.Log("start long method");
            await SomeMethod0();
            await SomeMethod1();
            await SomeMethod2();
            await SomeMethod3();
            await SomeMethod4();
            Debug.Log("end long method");
        }

        private async Task SomeMethod0()
        {
            Debug.Log($"method {nameof(SomeMethod0)}");
            await Task.Delay(1000);
        }
        private async Task SomeMethod1()
        {
            Debug.Log($"method {nameof(SomeMethod1)}");
            await Task.Delay(1000);
        }
        private async Task SomeMethod2()
        {
            Debug.Log($"method {nameof(SomeMethod2)}");
            await Task.Delay(1000);
        }
        private async Task SomeMethod3()
        {
            Debug.Log($"method {nameof(SomeMethod3)}");
            await Task.Delay(1000);
        }
        private async Task SomeMethod4()
        {
            Debug.Log($"method {nameof(SomeMethod4)}");
            await Task.Delay(1000);
        }
    }
}
