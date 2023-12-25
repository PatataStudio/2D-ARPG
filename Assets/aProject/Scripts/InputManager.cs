using PatataStudio.Utils;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PatataStudio.Input
{
	[RequireComponent(typeof(PlayerInput))]
	public class InputManager : Singleton<InputManager>
	{
		public Vector2 Movement {  get; private set; }
		public Vector2 MousePosition { get; private set; }

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
			Cursor.lockState = newState ? CursorLockMode.Confined : CursorLockMode.None;
		}

		private void OnApplicationFocus(bool focus)
		{
			SetCursorState(focus);
		}
	}
}