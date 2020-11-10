using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Animator aniRed;
    public FixedJoystick joystick;
    private void Start()
    {
        print("開始事件");
    }

    
    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);
    }

    public void Playamimation(string aniname) 
    {
        print(aniname);
        aniRed.SetTrigger(aniname);
        
        
    }

}
