using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // bu �eyin konumu(kamera), araban�nki ile ayn� olmal�
    [SerializeField] GameObject thingToFollow;
    void LateUpdate() //late update yapt���m�zda kamera daha yumu�ak hareket eder. oyun loopunda en son execute edilir.
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
    }
}
