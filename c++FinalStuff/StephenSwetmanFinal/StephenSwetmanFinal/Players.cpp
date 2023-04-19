#pragma once
#include<iostream>
#include"Players.h"
#include"Map.h"

using namespace std;


Player::Player()
{
	playerPos = mStart;//Start player location at beginning of map
}

//Return player health
int Player::getPlayHealth() {
	return playerHealth;
}

//Set player health
void Player::setPlayHealth(int toSet) {
	
	playerHealth = toSet;
}

//Get player Defense Buffs
int Player::getBuff() {
	if (playerArmor) {
		armorBuff = 4;
	}
	else {
		armorBuff = 0;
	}
	
	if (playerShield) {
		shieldBuff = 3;
	}
	else {
		shieldBuff = 0;
	}

	if (playerHelm) {
		helmBuff = 3;
	}
	else {
		helmBuff = 0;
	}

	return armorBuff + shieldBuff + helmBuff;
}

//View player inventory
void Player::viewPlayerInv() {
	for (int i = 0; i < playInv.size(); ++i) {
		cout << playInv[i] << endl;
	}
}

//Set player attack rating to double
void Player::setPlayHit(int dam) {
	hit = dam;
	if (hit == 2) {
		xxDamage = true;
	}
}


//Player attack
int Player::playerAttack(string weapon) {

	//Check to see if player attack rating is double
	if (xxDamage) {
		hit = 2;
	}
	else {
		hit = 1;
	}


	//Return enemy attack with weapon damage added
	if (weapon == "Sword") {
		hit = 6 * hit;
	}
	else if (weapon == "BattleAxe") {
		hit = 10 * hit;
	}
	else if (weapon == "Spear") {
		hit = 20 * hit;
	}
	else if (weapon == "Mace") {
		hit = 35 * hit;
	}
	else if (weapon == "Scimitar") {
		hit = 15 * hit;
	} 
	return hit;

}

//Player attack Scene
void Player::playerHit(int playAttk) {
	cout << "you hit the enemy dealing " << playAttk << " damage" << endl;
}
Player::~Player() {


}