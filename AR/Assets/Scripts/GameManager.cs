using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("紅蘑菇")]
    public Transform redmush;
    [Header("藍蘑菇")]
    public Transform bluemush;
    [Header("搖桿")]
    public FixedJoystick joystick;
    [Header("旋轉速度")]
    [Range(0.1f, 20f)]
    public float turn = 1.5f;
    [Header ("放大速度")]
    [Range(0f,5f)]
    public float size = 0.01f;

    private void Start()
    {
        print("開始事件");

    }
    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);
        redmush.Rotate(0, joystick.Horizontal*turn, 0);
        bluemush.Rotate(0, joystick.Horizontal * turn, 0);
        redmush.localScale += new Vector3(100,100,100)*joystick.Vertical*size;
    }
}
