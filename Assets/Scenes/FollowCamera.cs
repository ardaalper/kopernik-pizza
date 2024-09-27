using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // bu þeyin konumu(kamera), arabanýnki ile ayný olmalý
    [SerializeField] GameObject thingToFollow;
    void LateUpdate() //late update yaptýðýmýzda kamera daha yumuþak hareket eder. oyun loopunda en son execute edilir.
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
    }
}
