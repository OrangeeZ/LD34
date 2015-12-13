﻿using UnityEngine;
using System.Collections;

[CreateAssetMenu( menuName = "Create/Enemy Status Info" )]
public class EnemyCharacterStatusInfo : CharacterStatusInfo {

	public float AggroRadius;
	public RangedWeaponInfo Weapon1;
	//public float AttackRange;
	//public float SplashRadius;
	//public bool CanFriendlyFire;

	public override void Configure( csv.Values values ) {

		base.Configure( values );

		AggroRadius = values.Get( "AgroRadius", 0 );
		Weapon1 = values.GetScriptableObject<RangedWeaponInfo>( "Weapon1" );
		//AttackRange = values.Get( "AttackRange", 0 );
		//SplashRadius = values.Get( "SplashRadius", 0 );
		//CanFriendlyFire = values.Get( "FriendlyFire", "no" ) == "yes";
	}

}