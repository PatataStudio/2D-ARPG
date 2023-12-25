using UnityEngine;
using UnityEngine.InputSystem;

namespace PatataStudio.Input
{
	[RequireComponent(typeof(PlayerInput))]
	public class InputManager : MonoBehaviour
	{
		public static InputManager Instance;

		public Vector2 Movement {  get; private set; }
		public Vector2 MousePosition { get; private set; }

		private void Awake()
		{
			if(Instance == null)
			{
				Instance = this;
				DontDestroyOnLoad(this);
			}
			else
			{
				Destroy(this);
			}
		}

		public void OnMove(InputValue inputValue)
		{
			MoveInput(inputValue.Get<Vector2>());
		}

		public void OnLook(InputValue inputValue)
		{
			LookInput(inputValue.Get<Vector2>());
		}

		public void MoveInput(Vector2 newMovement)
		{
			Movement = newMovement;
		}

		public void LookInput(Vector2 newMousePosition)
		{
			MousePosition = newMousePosition;
		}
		private void SetCursorState(bool newState)
		{
			Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}

		private void OnApplicationFocus(bool focus)
		{
			SetCursorState(focus);
		}
	}
}