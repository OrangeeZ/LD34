﻿using System;
using UnityEngine;

public abstract class Weapon : Item {

	protected Action AttackCallback;

	protected Vector3 Direction;

	protected Weapon( ItemInfo info )
		: base( info ) {
	}

	public virtual void Setup( Character ownerCharacter, Vector3 direction, Action attackCallback ) {

		this.character = ownerCharacter;
		this.Direction = direction;
		this.AttackCallback = attackCallback;
	}

	public virtual WeaponInfo GetInfo() {

		return null;
	}

	public virtual void Attack( Character target, EnemyCharacterStatusInfo statusInfo ) {}

    public virtual void Attack( Vector3 direction ) {}

    public virtual bool CanAttack( Character target ) {

        return false;
    }

	public override void Apply() {

		character.Inventory.SetArmSlotItem( ( info as WeaponInfo ).SlotType, this );
	}
}

public abstract class Weapon<T> : Weapon where T : WeaponInfo {

	protected readonly T typedInfo;

	public Weapon( ItemInfo info )
		: base( info ) {

		this.typedInfo = info as T;
	}
}