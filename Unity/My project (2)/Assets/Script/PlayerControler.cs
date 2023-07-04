using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float mouseSensitivityHorizontal;
    [SerializeField]
    private float mouseSensitivityVertical;
    private bool pause;

    //[SerializeField]
    private PlayerMotor motor;
    
    private void Start()
    {
        pause=false;
        speed = 3f;
        mouseSensitivityHorizontal = 15f;
        mouseSensitivityVertical = 15f;
        motor = GetComponent<PlayerMotor>();
    }
    private void Update()
    {
        //Calculer la vitesse du mouvement du joueur
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * xMov;
        Vector3 moveVertical = transform.forward * zMov;

        Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;

        motor.Move(velocity);

        //On calcule la rotation du joueur en un Vector3
        float yRot = Input.GetAxisRaw("Mouse X");

        Vector3 rotation = new Vector3(0, yRot, 0) * mouseSensitivityHorizontal;
        motor.Rotate(rotation);

        //On calcule la rotation de la camera en un Vector3
        float xRot = Input.GetAxisRaw("Mouse Y");

        Vector3 cameraRotation = new Vector3(xRot, 0, 0) * mouseSensitivityVertical;
        motor.RotateCamera(cameraRotation);

        LockMouseCursor();
    }
    private void LockMouseCursor()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = false;
            Screen.lockCursor = !Screen.lockCursor;
        }
        if (Input.GetMouseButton(0) && !pause)
        {
            pause = true;
            Screen.lockCursor = true;
        }
    }
}
