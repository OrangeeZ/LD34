﻿using UnityEngine;
using System.Collections;
using UnityEngine.ScriptableObjectWizard;

[Category( "CharacterBase" )]
public class CharacterStatusInfo : ScriptableObject {

	[SerializeField]
	private CharacterStatus status;

	public CharacterStatus GetInstance( StatExpressionsInfo statExpressionsInfo ) {

		return new CharacterStatus( statExpressionsInfo ) {

			agility = { Value = status.agility.Value },
			strength = { Value = status.strength.Value }
		};
	}
}