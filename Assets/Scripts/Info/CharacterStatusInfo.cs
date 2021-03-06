﻿using UnityEngine;
using System.Collections;
using Expressions;
using UniRx;

[CreateAssetMenu( menuName = "Create/Status Info" )]
public class CharacterStatusInfo : ScriptableObject, ICsvConfigurable {

	public float MaxHealth;
	public float MoveSpeed;
	public float Damage;

	public float MaxAcorns;

	[SerializeField]
	private CharacterStatus status;

	public virtual CharacterStatus GetInstance() {

		return new CharacterStatus( this ) {

			Agility = {Value = status.Agility.Value},
			Strength = {Value = status.Strength.Value}
		};
	}

	public virtual void Configure( csv.Values values ) {

		MaxHealth = values.Get( "MaxHP", MaxHealth );
		MoveSpeed = values.Get( "Speed", MoveSpeed );
		Damage = values.Get( "DMG", Damage );
	}

}