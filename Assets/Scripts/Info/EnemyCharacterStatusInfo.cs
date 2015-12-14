﻿using UnityEngine;
using System.Collections;

[CreateAssetMenu( menuName = "Create/Enemy Status Info" )]
public class EnemyCharacterStatusInfo : CharacterStatusInfo {

	public float AggroRadius;
	public RangedWeaponInfo Weapon1;
	public ItemInfo[] ItemsToDrop;
	public EnemyCharacterPawn PawnPrefab;
	public float DropChance;
	public AudioClip[] EnemySpottedSound;
	public float SpawnInterval;
	public float SpeakChance;
	//public float AttackRange;
	//public float SplashRadius;
	//public bool CanFriendlyFire;

	public override void Configure( csv.Values values ) {

		base.Configure( values );

		AggroRadius = values.Get( "AgroRadius", 0 );
		Weapon1 = values.GetScriptableObject<RangedWeaponInfo>( "Weapon1" );
		ItemsToDrop = values.GetScriptableObjects<ItemInfo>( "DroppedItems" );
		DropChance = values.Get( "DropChance", 0f );
		SpawnInterval = values.Get( "RespawnTimer", -1f );
		SpeakChance = values.Get( "SpeakChance", 0.2f );
		PawnPrefab = values.GetPrefabWithComponent<EnemyCharacterPawn>( "Visual", fixName: false );

		//AttackRange = values.Get( "AttackRange", 0 );
		//SplashRadius = values.Get( "SplashRadius", 0 );
		//CanFriendlyFire = values.Get( "FriendlyFire", "no" ) == "yes";
	}

}