public class SomeGameplayClass : MonoBehaviour 
{
    void Update() {
        //..
        timer += Time.deltaTime;
        //...
        transform.Rotate(0, 0, degreesPerSecond * Time.deltaTime);
        ///
    }
}