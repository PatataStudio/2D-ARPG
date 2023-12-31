using PatataStudio.Input;
using PatataStudio.Utils.Extensions;
using UnityEngine;

namespace PatataStudio.ARPG.Entity
{
	[RequireComponent(typeof(MovementComponent))]
	public class PlayerController : MonoBehaviour, IInputController
	{
		private MovementComponent movementComponent;

		private void Start()
		{
			movementComponent = gameObject.GetOrAdd<MovementComponent>();
		}

		private void FixedUpdate()
		{
			movementComponent.Move(InputManager.Instance.Movement);
		}
	}
}